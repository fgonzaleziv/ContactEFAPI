using System.Xml.Linq;

namespace ContactEFAPI.Models
{
    public partial class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
         public string? Country { get; set; }

    }
}