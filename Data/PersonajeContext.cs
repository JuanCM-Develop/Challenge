using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetoAlk.Models.Requests;

    public class PersonajeContext : DbContext
    {
        public PersonajeContext (DbContextOptions<PersonajeContext> options)
            : base(options)
        {
        }

        public DbSet<RetoAlk.Models.Requests.Personaje> Personaje { get; set; }
    }
