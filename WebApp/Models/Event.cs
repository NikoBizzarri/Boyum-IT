using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Event
    {
        [Key]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateAndTime { get; set; }
    }
}
