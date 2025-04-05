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
                    editItem.Name = item.Name;
                    editItem.Description = item.Description;
                    editItem.Stock = item.Stock;
                    editItem.CurrentPricePerUnit = item.CurrentPricePerUnit;
                    editItem.LastStockedDate = editItem.ToString() == item.ToString() ? item.LastStockedDate : DateTime.Now;
                    editItem.Type = item.Type;
                    return _dbContext.SaveChanges() > 0;
                }
                return false;

            }
            else
            {
                _dbContext.Items.Add(item);
                return _dbContext.SaveChanges() > 0;
            }

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
