namespace Avanade.SubTCSE.Projeto.Application.AutoMapperConfigs.Profiles
{
    public static class Configs
    {
        public static AutoMapper.MapperConfiguration RegisterMappings() =>
            new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AllowNullCollections = true;
                cfg.AddProfile<EmployeeRoleProfile.EmployeeRoleProfile>();
                cfg.AddProfile<Employee.EmployeeProfile>();
            });
    }
}
