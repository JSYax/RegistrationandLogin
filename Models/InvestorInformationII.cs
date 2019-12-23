using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KudyFinancials.Models
{
    public class InvestorInformationII
    {
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string SMSCode { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressPostalCode { get; set; }
        public string AddressCountry { get; set; }
        public string Document{ get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
