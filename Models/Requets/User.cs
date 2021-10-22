using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace RetoAlk.Models.Requests
{
    public class User
    {
        [Key]
        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Password {get;set;}
        public int IdToken {get;set;}
    }
}