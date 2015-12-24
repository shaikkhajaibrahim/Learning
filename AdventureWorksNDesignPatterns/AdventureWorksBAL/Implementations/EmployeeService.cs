using AdventureWorksBAL.Interfaces;
using System.Collections.Generic;
using AdventureWorksDAL;
using AdventureWorksBAL.BusinessModel;
using System.Collections.ObjectModel;

namespace AdventureWorksBAL.Implementations
{
    public class EmployeeService : IEmployeeService
    {
        public IReadOnlyCollection<EmployeeView> GetAllEmployees()
        {
            IList<EmployeeView> employeeList = new List<EmployeeView>(7);
            AutoMapper.Mapper.CreateMap<vEmployee, EmployeeView>();
            using (AdventureWorksDataModel model = new AdventureWorksDataModel())
            {
               
                foreach(vEmployee employee in model.vEmployees)
                {
                    if (employeeList.Count > 5)
                    {
                        break;
                    }
                    employeeList.Add(AutoMapper.Mapper.Map<EmployeeView>(employee));
                }
            }
            return new ReadOnlyCollection<EmployeeView>(employeeList);
        }
    }
}
