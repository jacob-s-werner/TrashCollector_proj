using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector_proj.Models
{
    public class DayOfTheWeek
    {
        [Key]
        public int Id { get; set; }
        public string Day { get; set; }
    }
}
