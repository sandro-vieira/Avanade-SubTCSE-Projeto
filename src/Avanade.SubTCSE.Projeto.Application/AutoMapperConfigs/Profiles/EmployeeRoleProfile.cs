using AutoMapper;

namespace Avanade.SubTCSE.Projeto.Application.AutoMapperConfigs.Profiles
{
    public class EmployeeRoleProfile : Profile
    {
        public EmployeeRoleProfile()
        {
            CreateMap<Dtos.EmployeeRole.EmployeeRoleDto, Domain.Aggregates.EmployeeRole.Entities.EmployeeRole>()
                .ForCtorParam("RoleName", opt => opt.MapFrom(src => src.Role));

            CreateMap<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, Dtos.EmployeeRole.EmployeeRoleDto>()
                .ForMember(dest => dest.Identity, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.RoleName))
                .ForAllOtherMembers(i => i.Ignore());
        }
    }
}
