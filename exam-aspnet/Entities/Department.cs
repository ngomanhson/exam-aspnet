using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exam_aspnet.Entities
{
    [Table("department")]
    public class Department
	{
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public int NumberOfPersonnel { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}

