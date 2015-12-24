using AdventureWorksBAL.BusinessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AdventureWorksService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAdventureWorksEmployee" in both code and config file together.
    [ServiceContract]
    public interface IAdventureWorksEmployee
    {
        [OperationContract]
        List<EmployeeView> GetAllEmployees();
       
    }

    
}
