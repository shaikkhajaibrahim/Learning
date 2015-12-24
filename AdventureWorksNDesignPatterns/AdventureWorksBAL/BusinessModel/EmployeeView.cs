using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksBAL.BusinessModel
{
    [DataContract]
    public class EmployeeView
    {
        [DataMember]
        public int BusinessEntityID { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string MiddleName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Suffix { get; set; }

        [DataMember]
        public string JobTitle { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
        public string PhoneNumberType { get; set; }

        [DataMember]
        public string EmailAddress { get; set; }

        [DataMember]
        public int EmailPromotion { get; set; }

        [DataMember]
        public string AddressLine1 { get; set; }

        [DataMember]
        public string AddressLine2 { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string StateProvinceName { get; set; }

        [DataMember]
        public string PostalCode { get; set; }

        [DataMember]
        public string CountryRegionName { get; set; }

        [DataMember]
        public string AdditionalContactInfo { get; set; }
    }
}
