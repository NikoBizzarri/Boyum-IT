using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Partecipant
    {
        public string Fullname { get; set; }
        [Key]
        public string Email { get; set; }
        public string Phone { get; set; }

        public string EventId { get; set; }


    }

    public class PartecipantViewModel
    {
        public Partecipant Partecipant { get; set; }
        public IList<Event> Events { get; set; }
    }

}
