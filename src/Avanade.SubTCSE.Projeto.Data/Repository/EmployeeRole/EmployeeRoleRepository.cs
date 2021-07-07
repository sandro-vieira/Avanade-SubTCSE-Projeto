using Avanade.SubTCSE.Projeto.Data.Repository.Base;
using Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repository;

namespace Avanade.SubTCSE.Projeto.Data.Repository.EmployeeRole
{
    public class EmployeeRoleRepository : 
        BaseRepository<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, string>,
        IEmployeeRoleRepository
    {

    }
}
