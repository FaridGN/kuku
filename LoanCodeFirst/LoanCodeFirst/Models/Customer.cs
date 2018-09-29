using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;

namespace LoanCodeFirst.Models
{
    [Table(name: "Customers")]
    class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required, MinLength(12, ErrorMessage = "Maximum Length Reached"), MaxLength(12, ErrorMessage = "Maximum Length Reached")]
        public string Passport { get; set; }
    }
  
}
