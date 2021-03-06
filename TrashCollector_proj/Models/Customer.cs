using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector_proj.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ForeignKey("DayOfTheWeek")]
        public string WeeklyPickUpDayId { get; set; }
        public DayOfTheWeek WeeklyPickUpDay { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }

        [NotMapped]
        public List<ChargeToCustomer> ListOfCurrentCharges;
        public List<OneTimePickup> ListOfCurrentOneTimePickups;
        public List<TempPickUpSuspension> ListOfCurrentTempPickUpSuspensions;
        public SelectList DaysOfTheWeek;
    }
}
