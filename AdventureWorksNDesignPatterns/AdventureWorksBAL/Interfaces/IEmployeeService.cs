using AdventureWorksBAL.BusinessModel;
using AdventureWorksDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksBAL.Interfaces
{
    /// <summary>
    /// This interface contains the details to access the employe service
    /// </summary>
    public interface IEmployeeService
    {
        IReadOnlyCollection<EmployeeView> GetAllEmployees();
    }
}
