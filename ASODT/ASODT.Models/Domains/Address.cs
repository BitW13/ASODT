namespace ASODT.Models.Domains
{
    public class Address
    {
        public int Id { get; set; }
        public City City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
        public byte Floor { get; set; }
    }
}
