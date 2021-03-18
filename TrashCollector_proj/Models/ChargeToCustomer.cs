using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector_proj.Models
{
    public class ChargeToCustomer
    {
        [Key]
        public int Id { get; set; }
        public DateTime? TimeOfPickup { get; set; }
        public double ChargeAmount { get; set; }
       
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
