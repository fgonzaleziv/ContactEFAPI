using System.ComponentModel.DataAnnotations.Schema;

namespace ContactEFAPI.Models
{
    public partial class Department
    {
        public int Id { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; } = null!;
        public int? LocationId { get; set; }
        [ForeignKey("LocationId")]
        public virtual Location? Location { get; set; }
        public int PrimaryId { get; set; }
        [ForeignKey("PrimaryId")]
        public virtual Contact Primary {get;set;} = null!;
        public int SecondaryId { get; set; }
        [ForeignKey("SecondaryId")]
        public virtual Contact Secondary { get;set;} = null!;

    }
}
