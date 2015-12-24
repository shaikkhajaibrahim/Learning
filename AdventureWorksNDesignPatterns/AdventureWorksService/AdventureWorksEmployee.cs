using AdventureWorksBAL.BusinessModel;
using AdventureWorksBAL.Implementations;
using AdventureWorksBAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AdventureWorksService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class AdventureWorksEmployee : IAdventureWorksEmployee
    {
        private IEmployeeService employeeService;

        /// <summary>
        /// todo : Change This to Constructor Injection
        /// </summary>
        public AdventureWorksEmployee()
        {
            employeeService = new EmployeeService();

        }

        public List<EmployeeView> GetAllEmployees()
        {
            return employeeService.GetAllEmployees().ToList();
        }
    }
}
