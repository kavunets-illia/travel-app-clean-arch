namespace TravelApp.Domain.Entities
{
    public class TravelDestination
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public decimal Price { get; set; }

        public TravelDestination(string id, string name, string country, decimal price)
        {
            Id = id;
            Name = name;
            Country = country;
            Price = price;
        }
    }
}
