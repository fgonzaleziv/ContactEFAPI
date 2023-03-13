using System.ComponentModel.DataAnnotations.Schema;

namespace ContactEFAPI.Models
{
    public partial class DepartmentDTO
    {
            public int Id { get; set; }
            public required string Code { get; set; }
            public required string Name { get; set; }
            public int? PrimaryId { get; set; }
            public int? SecondaryId { get; set; }

    }
}
