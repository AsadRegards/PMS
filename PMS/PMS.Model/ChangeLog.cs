namespace PMS.PMS.Model
{
    public class ChangeLog
    {
        public int Id { get; set; }
        public ChangeType ChangeType { get; set; }
        public string UserId { get; set; }
        public int ObjectId {  get; set; }  
        public string? PropertyChanged { get; set; } 
        public DateTime TimeStamp { get; set; }
        public ObjectType ObjectType { get; set; }
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
    }
}
