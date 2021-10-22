using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RetoAlk.Models.Requests
{
    public class Personaje
    {
        [Key]
        public string Nombre{get;set;}
        public string Imagen{get;set;}
        public int Edad{get;set;}
        public float Peso{get;set;}
        public string Historia{get;set;}
        public List<Pelicula> PelSeriQueAparece {get;set;}
    }
}