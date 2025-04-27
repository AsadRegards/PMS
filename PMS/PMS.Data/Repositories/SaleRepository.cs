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

        public void RemoveSaleItem(int saleItemId)
        {
            var saleItem = _dbContext.SaleItems.Where(x => x.Id == saleItemId).FirstOrDefault();
            if (saleItem != null)
            {
                _dbContext.SaleItems.Remove(saleItem);
                _dbContext.SaveChanges();
                var remainingItemCount = _dbContext.SaleItems.Where(x => x.SaleId == saleItem.SaleId).Count();
                if(remainingItemCount == 0)
                {
                   var saleObj =  _dbContext.Sales.Where(x => x.Id == saleItem.SaleId).FirstOrDefault();
                    saleObj.Status = Status.Returned;
                    _dbContext.SaveChanges();
                }
            }
        }

        /*
         * This method is used where user need to return a sale item but not its whole quantity but few.
         */
        public void updateSaleItemQuantity(int saleItemId, int quantityToReturn)
        {
            var saleItem = _dbContext.SaleItems.Where(x => x.Id == saleItemId).FirstOrDefault();
            if(saleItem != null)
            {
                saleItem.Quantity -= quantityToReturn;
                _dbContext.SaveChanges();
            }
        }

        public void ReturnCompleteSale(int saleitemId)
        {
            var saleItem = _dbContext.SaleItems.Where(x => x.Id == saleitemId).FirstOrDefault();
            if (saleItem != null)
            {
                int saleId = saleItem.SaleId;
                var saleItemList = _dbContext.SaleItems.Where(x => x.SaleId == saleId).ToList();
                _dbContext.SaleItems.RemoveRange(saleItemList);
                var saleObj = _dbContext.Sales.Where(x => x.Id == saleId).FirstOrDefault();
                saleObj.Status = Status.Returned;
                _dbContext.SaveChanges();
            }
        }

        public List<SaleItemDTO> GetSaleItemsBySaleId(int saleId)
        {
            var saleItemsWithNames = _dbContext.SaleItems.Where(x=>x.SaleId == saleId)
              .Join(_dbContext.Items,
                    sale => sale.ItemId,
                    item => item.Id,
                    (sale, item) => new SaleItemDTO
                    {
                        Id = sale.Id,
                        Name = item.Name,
                        Quantity = sale.Quantity,
                        PricePerUnit = sale.PricePerUnit,
                        TotalPrice = sale.Quantity * sale.PricePerUnit,

                        
                    })
              .ToList();
            return saleItemsWithNames;
        }

        public List<Sale> GetAllSales(DateTime startDate, DateTime endDate)
        {
            return _dbContext.Sales.Where(x => x.SaleDate >= startDate && x.SaleDate <= endDate).ToList();
        }

        private void AddChangeLog(ChangeLog changeLog)
        {
            _dbContext.ChangeLog.Add(changeLog);
            _dbContext.SaveChanges();
        }
    }
}
