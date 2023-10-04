using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exam_aspnet.Entities
{
    [Table("employee")]
    public class Employee
	{
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string EmployeeCode { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        [Required]
        [ForeignKey("department_id")]
        public Department Department { get; set; }

        [Required]
        public string Rank { get; set; }
    }
}

