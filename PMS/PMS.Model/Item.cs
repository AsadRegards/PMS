using PMS.PMS.Data.Repositories;

namespace PMS.PMS.Model
{
    public class Item
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Description { get; set; } 
        public string Type { get; set; }    
        public int Stock {  get; set; } 
        public int CurrentPricePerUnit { get;set; }

        public override string ToString()
        {
            return $"{Id}|{Name}|{Description}|{CurrentPricePerUnit}|{Stock}|{ItemRepository.Instance.GetItemUpdateInfo(Id)}";
        }
    }
}

