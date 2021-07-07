using Avanade.SubTCSE.Projeto.Data.Repository.Base;
using Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Interfaces.Repositories;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Data.Repository.Employee
{
    public class EmployeeRepository :
        BaseRepository<Domain.Aggregates.Employee.Entities.Employee, string>,
        IEmployeeRepository
    {
    }
}
