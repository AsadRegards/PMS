namespace PMS.PMS.Model
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
    }
}

