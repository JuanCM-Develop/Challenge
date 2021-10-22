using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RetoAlk.Models.Requests;
using System;
using System.Linq;

namespace RetoAlk.Models
{
    public static class SeedPersonajes
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PersonajeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PersonajeContext>>()))
            {
                // Look for any movies.
                if (context.Personaje.Any())
                {
                    return;   // DB has been seeded
                }

                 Personaje p1 = new Personaje
                {
                    Nombre = "Mickey Mouse",
                    Imagen = "Raton",
                    Edad = 30,
                    Peso = 330,
                    Historia = "Super relato de aventuras" 
                };


                Personaje p2 = new Personaje
                {
                    Nombre = "Donald",
                    Imagen = "Pato",
                    Edad = 30,
                    Peso = 330,
                    Historia = "Super relato de aventuras - Donald"
                };

                Personaje p3 = new Personaje
                {
                    Nombre = "Pluto",
                    Imagen = "Perro",
                    Edad = 30,
                    Peso = 330,
                    Historia = "Super relato de aventuras - Pluto"
                };

                Personaje p4 = new Personaje{    
                    Nombre = "Mimi",
                    Imagen = "Raton",
                    Edad = 30,
                    Peso = 330,
                    Historia = "Super relato de aventuras - Mimi"
                };


                context.Personaje.AddRange(
                    p1,p2,p3,p4
                );

                context.SaveChanges();
            }
        }
    }
}