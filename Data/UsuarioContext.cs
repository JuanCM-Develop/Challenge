using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetoAlk.Models.Requests;

    public class UsuarioContext : DbContext
    {
        public UsuarioContext (DbContextOptions<UsuarioContext> options)
            : base(options)
        {
        }

        public DbSet<RetoAlk.Models.Requests.User> User { get; set; }
    }
