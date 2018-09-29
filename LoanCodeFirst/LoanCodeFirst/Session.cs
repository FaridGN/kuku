using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCodeFirst
{
    public static class Session
    {

         static Session()
        {
            FullNames = new List<string>();
            FullNames.Add("myname");
            Name = new List<string>();
            Name.Add("FirtName");
            Surname = new List<string>();
            Surname.Add("LastName");
            Passport = new List<string>();
            Passport.Add("Passport1");
            LoanDate = new List<DateTime>();
            LoanDate.Add(DateTime.Now);
            Amount = new List<decimal>();
            Amount.Add(Convert.ToDecimal(200.25));

        }

        public static List<string> FullNames { get; set; }
        public static List<string> Name { get; set; }
        public static List<string> Surname { get; set; }
        public static List<string> Passport { get; set; }
        public static List<DateTime> LoanDate { get; set; }
        public static List<decimal> Amount { get; set; }

    }
}
