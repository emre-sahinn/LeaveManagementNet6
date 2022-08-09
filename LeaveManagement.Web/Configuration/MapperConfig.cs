using AutoMapper;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            //LeaveType'i LeaveTypeVM map ediyoruz ve ReverseMap ile bunun tersi de olabilir diyoruz
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
