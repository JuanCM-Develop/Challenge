using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RetoAlk.Models.Requests;
using System;
using System.Linq;

namespace RetoAlk.Models
{
    public static class SeedUsuario
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UsuarioContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<UsuarioContext>>()))
            {
                // Look for any movies.
                if (context.User.Any())
                {
                    return;   // DB has been seeded
                }

                User u1 = new User
                {    
                    Id = 1,
                    Nombre = "Juan",
                    Password = "123",
                    IdToken = 4
                };


                User u2 = new User
                {    
                    Id = 2,
                    Nombre = "Seba",
                    Password = "123",
                    IdToken = 20
                };


                context.User.AddRange(
                    u1,u2
                );

                context.SaveChanges();
            }
        }
    }
}