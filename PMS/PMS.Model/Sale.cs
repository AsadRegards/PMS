namespace PMS.PMS.Model
{
    internal class Sale
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public int Amount { get; set; }
        public int Discount {  get; set; }  
        public DiscountType DiscountType { get; set; }
        public ICollection<SaleItems> SaleItems { get; set; }
        public DateTime SaleDate { get; set; }  
        public int UserId { get; set; } 
    }
}

