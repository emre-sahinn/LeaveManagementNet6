using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Range(1,50, ErrorMessage = "Invalid range, must be in between 1-50")]
        public int NumberOfDays { get; set; }
        [Required]
        public int Period { get; set; }
        //dikkat: vm icinde direkt data model referansi bulundurma
        public LeaveTypeVM? LeaveType { get; set; }
    }
}