using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace RetoAlk.Models.Requests
{
    public class Genero
    {
        [Key]
        public string Nombre {get;set;}
        public string Imagen {get;set;}
    
        public List<Pelicula> PeliculasAsociadas {get;set;}

    }
}