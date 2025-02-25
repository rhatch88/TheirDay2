namespace TheirDay2.Models
{
    public class Event
    {
        public int Id { get; set; } // This is the primary key
        public string Name { get; set; }
        public string AgeGroup { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public bool IsOutdoor { get; set; }

    }
}
