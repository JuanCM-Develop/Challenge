using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RetoAlk.Models.Requests;
using System;
using System.Linq;

namespace RetoAlk.Models
{
    public static class SeedPeliculas
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PeliculaContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PeliculaContext>>()))
            {
                // Look for any movies.
                if (context.Pelicula.Any())
                {
                    return;   // DB has been seeded
                }

                 Pelicula p1 = new Pelicula
                {
                    Imagen = "Calabozo",
                    Titulo = "Reino de corazones",
                    FechaCreacion = "19/07/1996",
                    Calificacion = 4
                };


                Pelicula p2 = new Pelicula
                {
                    Imagen = "Castillo",
                    Titulo = "Reino de corazones - Oscuro",
                    FechaCreacion = "30/08/2010",
                    Calificacion = 2
                };

                Pelicula p3 = new Pelicula
                {
                    Imagen = "Mar",
                    Titulo = "Mar Oscuro",
                    FechaCreacion = "23/12/2015",
                    Calificacion = 2
                };

                Pelicula p4 = new Pelicula   
                {
                    Imagen = "Fuerte",
                    Titulo = "Age of empire 2",
                    FechaCreacion = "12/04/2000",
                    Calificacion = 2
                };


                context.Pelicula.AddRange(
                    p1,p2,p3,p4
                );

                context.SaveChanges();
            }
        }
    }
}