using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LoanCodeFirst.Models
{
    class BankDBContext: DbContext
    {
        public BankDBContext() : base("MyDB")
        {
           
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Loan> Loans { get; set; }
    }
}
