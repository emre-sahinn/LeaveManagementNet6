using AutoMapper;
using LeaveManagement.Data;
using LeaveManagement.Common.Models;

namespace LeaveManagement.Application.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            //LeaveType'i LeaveTypeVM map ediyoruz ve ReverseMap ile bunun tersi de olabilir diyoruz
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            CreateMap<Employee, EmployeeListVM>().ReverseMap();
            CreateMap<Employee, EmployeeAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationEditVM>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestCreateVM > ().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestVM > ().ReverseMap();
        }
    }
}
