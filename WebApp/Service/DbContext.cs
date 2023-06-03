using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Service
{
    public class MvcContext : DbContext
    {
        protected override void OnConfiguring
       (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "AuthorDb");
        }
        public DbSet<Event> Events { get; set; }
        public DbSet<Partecipant> Partecipants { get; set; }
    }
}
