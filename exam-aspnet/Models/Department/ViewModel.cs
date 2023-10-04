using System;
using System.ComponentModel.DataAnnotations;

namespace exam_aspnet.Models.Department
{
	public class ViewModel
    {
        [Required(ErrorMessage = "Please enter a department name")]
        [MinLength(6, ErrorMessage = "Please enter a minimum of 6 characters")]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Please enter a department code")]
        [Display(Name = "Code")]
        public string code { get; set; }

        [Required(ErrorMessage = "Please enter a location")]
        [Display(Name = "Location")]
        public string location { get; set; }

        [Required(ErrorMessage = "Please enter the number of personnel")]
        [Display(Name = "Personnel")]
        public int NumberOfPersonals { get; set; }
    }
}


