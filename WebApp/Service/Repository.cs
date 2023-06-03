using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApp.Models;
using WebApp.Service.Interfaces;

namespace WebApp.Service
{
    public class Repository : IRepository
    {
        public Repository()
        {
            using (var context = new MvcContext())
            {
                var events = new List<Event>
                {
                new Event
                {
                    DateAndTime = DateTime.Now.AddDays(10),
                    Description = "The best annual party!!",
                    Name = "Annual party"
                },
                 new Event
                {
                    DateAndTime = DateTime.Now.AddDays(20),
                    Description = "The best React course on the internet",
                    Name = "Intro course to React.js"
                },
                new Event
                {
                    DateAndTime = DateTime.Now.AddDays(30),
                    Description = "The best DB learning path",
                    Name = "Learning in databases"
                }
                };
                if (!context.Events.Any())
                {
                    context.Events.AddRange(events);
                    context.SaveChanges();
                }
            }
        }


        public List<Event> GetEvents()
        {
            using (var context = new MvcContext())
            {
                var list = context.Events
                    .ToList();
                return list;
            }
        }

        public void AddPartecipant(Partecipant entry)
        {
            using (var context = new MvcContext())
            {
                var result = context.Partecipants.Add(entry);
            }
        }

    }
}