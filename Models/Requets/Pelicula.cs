using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace RetoAlk.Models.Requests
{
    public class Pelicula
    {

        public string Imagen {get;set;}
        [Key]
        public string Titulo {get;set;}
        public string FechaCreacion {get;set;}
        public int Calificacion {get;set;}
        public List<Personaje> PersonajesAsociados {get;set;}

    }
}