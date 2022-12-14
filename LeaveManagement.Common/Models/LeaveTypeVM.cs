using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Common.Models
{
    //view model: database deki bütün satilari gormesine(LeaveType) gerek yok sadece ilgili olanlari(LeaveTypeVM) gorsun
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Default Number of Days")]
        [Required]
        [Range(1,25, ErrorMessage = "Please enter a valid number" )]
        public int DefaultDays { get; set; }
    }
}
