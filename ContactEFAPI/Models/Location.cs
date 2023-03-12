using System.Xml.Linq;

namespace ContactEFAPI.Models
{
    public partial class Location
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required  string Address { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }
        public required string PostalCode { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
         public string? Country { get; set; }

    }
}