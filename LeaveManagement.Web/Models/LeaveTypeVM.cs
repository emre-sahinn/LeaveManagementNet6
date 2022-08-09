using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    //view model: database deki bütün satilari gormesine(LeaveType) gerek yok sadece ilgili olanlari(LeaveTypeVM) gorsun
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Leave Type Name")]
        public string Name { get; set; }

        [Display(Name = "Default Number of Days")]
        public int DefaultDays { get; set; }
    }
}
