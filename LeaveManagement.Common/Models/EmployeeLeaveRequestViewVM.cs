namespace LeaveManagement.Common.Models
{
    public class EmployeeLeaveRequestViewVM
    {
        public EmployeeLeaveRequestViewVM(List<LeaveAllocationVM> leaveAllocations, List<LeaveRequestVM> leaveRequests)
        {
            this.LeaveRequests = leaveRequests;
            this.LeaveAllocations = leaveAllocations;
        }

        public List<LeaveRequestVM> LeaveRequests { get; set; }
        public List<LeaveAllocationVM> LeaveAllocations { get; set; }

    }
}
