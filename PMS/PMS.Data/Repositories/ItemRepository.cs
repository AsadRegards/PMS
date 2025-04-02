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

        public bool SaveItem(Item item)
        {
            _dbContext.Items.Add(item);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
