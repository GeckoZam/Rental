namespace PropertyRental.Models
{
    public class Property
    {
        public int PropertyId { get; set; }
        public string UserId { get; set; }
        public string OwnerId { get; set; }
        public DateTime StartDate { get; set; }
        public string Address { get; set; }
        public int PricePerNight { get; set; }
        public int Nights { get; set; }
        public int TotalCost { get; set; }
    }
}
