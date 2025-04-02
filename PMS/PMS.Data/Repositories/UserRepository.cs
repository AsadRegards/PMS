using PMS.PMS.Model;
using System;
using System.Linq;

namespace PMS.PMS.Data.Repositories
{
    internal class UserRepository
    {
        // Static instance of the class
        private static UserRepository _instance;

        // Lock object for thread safety
        private static readonly object _lock = new object();

        // Readonly PmsDbContext
        readonly PmsDbContext _dbContext;

        // Public property to access the current user
        public User CurrentUser { get; set; }

        // Private constructor to prevent instantiation outside the class
        private UserRepository()
        {
            _dbContext = PmsDbContext.Instance;
        }

        // Public static method to get the single instance
        public static UserRepository Instance
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
                            _instance = new UserRepository();
                        }
                    }
                }
                return _instance;
            }
        }

        // Method to get a user by login name
        public User GetUserByLoginName(string loginName)
        {
            return _dbContext.Users.Where(x => x.LoginName == loginName).FirstOrDefault();
        }

        // Method to save a user
        public bool SaveUser(User user)
        {
            _dbContext.Users.Add(user);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
