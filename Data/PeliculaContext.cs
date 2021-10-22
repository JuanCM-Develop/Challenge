using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetoAlk.Models.Requests;

    public class PeliculaContext : DbContext
    {
        public PeliculaContext (DbContextOptions<PeliculaContext> options)
            : base(options)
        {
        }

        public DbSet<RetoAlk.Models.Requests.Pelicula> Pelicula { get; set; }
    }
