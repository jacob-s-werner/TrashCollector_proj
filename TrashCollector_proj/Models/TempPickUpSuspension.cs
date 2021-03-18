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
    public class TempPickUpSuspension
    {
        [Key]
        public int Id { get; set; }
        public DateTime? StartDate{ get; set; }
        public DateTime? EndDate { get; set; }
    }
}