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

    }

    public class PartecipantViewModel
    {
        public IList<Partecipant> Partecipants { get; set; }
        public IList<Event> Events { get; set; }
    }

}
