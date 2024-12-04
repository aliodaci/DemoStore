using AutoMapper;

namespace DemoStore.WebUI.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<TblEmployee,ResultEmployeeDTO>();
            CreateMap<ResultEmployeeDTO, TblEmployee>();

            CreateMap<TblEmployee,CreateEmployeeDTO>().ReverseMap();
        }
    }
}
