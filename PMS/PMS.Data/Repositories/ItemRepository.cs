using Microsoft.EntityFrameworkCore;
using PMS.PMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.PMS.Data.Repositories
{
    internal class ItemRepository
    {
        private static ItemRepository _instance;

        private static readonly object _lock = new object();
        // Readonly PmsDbContext
        readonly PmsDbContext _dbContext;

        private ItemRepository()
        {
            _dbContext = PmsDbContext.Instance;
        }

        public static ItemRepository Instance
        {
            get
            {
                // Double-check locking for thread safety
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ItemRepository();
                        }
                    }
                }
                return _instance;
            }
        }

        public bool SaveItem(Item item,bool isEditItem, int itemId)
        {
            if (isEditItem)
            {
                var editItem = _dbContext.Items.Where(x => x.Id == itemId).FirstOrDefault();
                if(editItem != null)
                {
                    var changeLogs = GetObjectChangesLog(editItem, item);
                    editItem.Name = item.Name;
                    editItem.Description = item.Description;
                    editItem.Stock = item.Stock;
                    editItem.CurrentPricePerUnit = item.CurrentPricePerUnit;
                    editItem.Type = item.Type;

                    var isSuccess =  _dbContext.SaveChanges() > 0;
                    if (isSuccess)
                        changeLogs.ForEach(x => AddChangeLog(x));

                    return isSuccess;
                }
                return false;

            }
            else
            {
                _dbContext.Items.Add(item);
                ChangeLog log = new ChangeLog()
                {
                    ChangeType = ChangeType.Insert,
                    ObjectType = ObjectType.Item,
                    TimeStamp = DateTime.Now,
                    UserId = UserRepository.Instance.CurrentUser.Id + "#" + UserRepository.Instance.CurrentUser.Name,

                };
                var isSuccess = _dbContext.SaveChanges() > 0;
                if(isSuccess)
                    AddChangeLog(log);
                return isSuccess;
            }

        }

        public string GetItemUpdateInfo(int itemId)
        {
            var lastChangeLog = _dbContext.ChangeLog.Where(x=>x.ObjectId == itemId).OrderBy(x=>x.TimeStamp).FirstOrDefault();
            if (lastChangeLog != null) {
                return lastChangeLog.UserId + " changed " + lastChangeLog.PropertyChanged + " to " + lastChangeLog.NewValue;
            }
            return "No change";
        }

        private List<ChangeLog> GetObjectChangesLog(Item oldObject, Item newObject)
        {
            var result = new List<ChangeLog>();

            void AddChange<T>(T oldValue, T newValue, string propertyName, string? displayName = null)
            {
                if (!Equals(oldValue, newValue))
                {
                    result.Add(new ChangeLog
                    {
                        ChangeType = ChangeType.Update,
                        ObjectType = ObjectType.Item,
                        ObjectId = oldObject.Id,
                        OldValue = oldValue?.ToString(),
                        NewValue = newValue?.ToString(),
                        PropertyChanged = displayName ?? propertyName
                    });
                }
            }

            AddChange(oldObject.Type, newObject.Type, nameof(oldObject.Type));
            AddChange(oldObject.Name, newObject.Name, nameof(oldObject.Name));
            AddChange(oldObject.Description, newObject.Description, nameof(oldObject.Description));
            AddChange(oldObject.Stock, newObject.Stock, nameof(oldObject.Stock));
            AddChange(oldObject.CurrentPricePerUnit, newObject.CurrentPricePerUnit, "Price");

            var now = DateTime.Now;
            var currentUserId = UserRepository.Instance.CurrentUser.Id;
            var currentUserName = UserRepository.Instance.CurrentUser.Name;

            foreach (var log in result)
            {
                log.TimeStamp = now;
                log.UserId = currentUserId + "#" + currentUserName;
            }

            return result;
        }


        private void AddChangeLog(ChangeLog changeLog)
        {
            _dbContext.ChangeLog.Add(changeLog);
            _dbContext.SaveChanges();
        }

        public Item GetItemById(int itemId)
        {
            var item = _dbContext.Items.Where(x=>x.Id == itemId).FirstOrDefault();
            return item;
        }

        public List<Item> GetAllItems(string itemNameFilter = "", int StockLessThanFilter = 0)
        {
            var list = _dbContext.Items.ToList();
            if (!string.IsNullOrWhiteSpace(itemNameFilter))
            {
                list = list.Where(x=>x.Name.ToLower().Contains(itemNameFilter.ToLower())).ToList();
            }
            if (StockLessThanFilter > 0) { 
                list = list.Where(x=>x.Stock < StockLessThanFilter).ToList();
            }
            return list;
        }

        public bool DeleteItemById(int itemId) {

            var item = _dbContext.Items.Where(x => x.Id == itemId).FirstOrDefault();
            if (item != null)
            {
                _dbContext.Items.Remove(item);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
