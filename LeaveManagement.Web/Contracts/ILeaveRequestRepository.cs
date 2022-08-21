using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Contracts
{
    public interface ILeaveRequestRepository : IGenericReposityory<LeaveRequest>
    {
        Task<bool> CreateLeaveRequest(LeaveRequestCreateVM request);
        Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();
        Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);
        Task<List<LeaveRequest>> GetAllAsync(string employeeId);
        Task ChangeApprovalStatus(int leaveRequestId, bool approved);
        Task CancelLeaveReqest(int leaveRequestId);
        Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();
    }
}
