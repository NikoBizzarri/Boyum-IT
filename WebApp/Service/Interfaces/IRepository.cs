using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Service.Interfaces
{
    public interface IRepository
    {
        List<Event> GetEvents();
        void AddPartecipant(Partecipant entry);

    }
}
