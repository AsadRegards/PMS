namespace PMS.PMS.Model
{
    public class SaleItems
    {
        public int Id { get; set; } 
        public int SaleId { get; set; } 
        public int ItemId { get; set; }
        public int PricePerUnit {  get; set; }  
        public int Quantity { get; set; }   
    }
}

