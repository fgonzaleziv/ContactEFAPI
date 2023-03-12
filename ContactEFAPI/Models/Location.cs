using System.Xml.Linq;

namespace ContactEFAPI.Models
{
    public partial class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}