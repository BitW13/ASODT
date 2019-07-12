namespace ASODT.Models.Domains
{
    public class Route
    {
        public int Id { get; set; }
        public Address StartAddress { get; set; }
        public Address EndAddress { get; set; }
        public Coordinate StartCoordinate { get; set; }
        public Coordinate EndCoordinate { get; set; }
        public double Distance { get; set; }
    }
}