using Microsoft.EntityFrameworkCore;
using PMS.PMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.PMS.Data.Repositories
{
    internal class SaleRepository
    {
        private static SaleRepository _instance;

        private static readonly object _lock = new object();
        // Readonly PmsDbContext
        readonly PmsDbContext _dbContext;

        private SaleRepository()
        {
            _dbContext = PmsDbContext.Instance;
        }

        public static SaleRepository Instance
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
                            _instance = new SaleRepository();
                        }
                    }
                }
                return _instance;
            }
        }

        public bool SaveSale(Sale sale)
        {
            _dbContext.Sales.Add(sale);
            ChangeLog log = new ChangeLog()
            {
                ChangeType = ChangeType.Insert,
                ObjectType = ObjectType.Sale,
                TimeStamp = DateTime.Now,
                UserId = UserRepository.Instance.CurrentUser.Id + "#" + UserRepository.Instance.CurrentUser.Name,
            };
            var isSuccess =  _dbContext.SaveChanges() > 0;
            if (isSuccess) {
                log.ObjectId = sale.Id;
                AddChangeLog(log);
                UpdateStock(sale);
            }
            return isSuccess;
        }

        private void UpdateStock(Sale sale)
        {
            var saleItemsList = sale.SaleItems.ToList();
            for(int i=0; i< saleItemsList.Count; i++)
            {
                var item = _dbContext.Items.Where(x => x.Id == saleItemsList[i].ItemId).FirstOrDefault();
                if (item != null)
                {
                    item.Stock -= saleItemsList[i].Quantity;
                }


            }
            _dbContext.SaveChanges();
        }

        private void AddChangeLog(ChangeLog changeLog)
        {
            _dbContext.ChangeLog.Add(changeLog);
            _dbContext.SaveChanges();
        }
    }
}
