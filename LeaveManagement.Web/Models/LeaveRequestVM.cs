namespace LeaveManagement.Web.Models
{
    public class LeaveRequestVM : LeaveRequestCreateVM
    {
        public int Id { get; set; }

        public LeaveTypeVM LeaveType { get; set; }

        public DateTime DateRequested { get; set; }

        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }

        public string? RequestEmployeeId { get; set; }
        public EmployeeListVM Employee { get; set; }
    }
}
