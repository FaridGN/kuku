﻿using LoanCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCodeFirst
{
    [Table(name:"Loans")]
    class Loan
    {
        [Key]
        public int id { get; set; }
        [Required]
        public DateTime LoanDate { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
