namespace LeaveManagement.Web.Models
{
    public class EmployeeAllocationVM: EmployeeListVM
    {
        public string EmployeeId { get; set; }
        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
    }
}
