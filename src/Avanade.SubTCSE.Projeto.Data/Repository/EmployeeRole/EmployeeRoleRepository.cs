using Avanade.SubTCSE.Projeto.Data.Repository.Base;
using Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repository;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository.MongoDB;

namespace Avanade.SubTCSE.Projeto.Data.Repository.EmployeeRole
{
    public class EmployeeRoleRepository :
        BaseRepository<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, string>,
        IEmployeeRoleRepository
    {
        public EmployeeRoleRepository(IMongoDBContext mongoDBContext)
            : base(mongoDBContext, "employeeRole")
        {
        }
    }
}
