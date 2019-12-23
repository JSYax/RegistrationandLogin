using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace KudyFinancials.Models
{
    public class InvestorInformationIII
    {
        public string BankNUBANNumber { get; set; }
        public string BankSWIFTCode { get; set; }
        public string BankSortCode { get; set; }
        public string BankName { get; set; }
        public string BankAddressLine1 { get; set; }
        public string BankAddressLine2 { get; set; }
        public string BankAddressCity { get; set; }
        public string BankAddressState { get; set; }
        public string BankAddressPostalCode { get; set; }
        public string BankAddressCountry { get; set; }
        public string NOKFirstName { get; set; }
        public string NOKLastName { get; set; }
        [Email]
        public string NOKEmail { get; set; }
        public string NOKPhoneNumber { get; set; }
        public string NOKAddressLine1 { get; set; }
        public string NOKAddressLine2 { get; set; }
        public string NOKAddressCity { get; set; }
        public string NOKAddressState { get; set; }
        public string NOKAddressPostalCode { get; set; }
        public string NOKAddressCountry { get; set; }
    }
}
