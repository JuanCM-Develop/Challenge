using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RetoAlk.Models.Requests;

namespace RetoAlk.Controllers
{
    [Route("api/[controller]/{id}")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private static int valorId = 1;
        private static int valorIdToken = 100;
        private readonly UsuarioContext _context;

        public AuthController(UsuarioContext context)
        {
            _context = context;
        }

        /*/ GET: api/Auth
        [HttpGet]
        public string Inicio()
        {
            return  "Agregue un usuario y contraseña a la url";
        }
        */
        
        [HttpGet]
        public User Login ()
        {
            User usuario = new User();
            usuario.Nombre = "Ingrese usuario";
            usuario.Password = "auto cifrado";
            usuario.Id = valorId;
            usuario.IdToken = valorIdToken;
            valorId++;
            valorIdToken += 10;

            return usuario;
        }

        [HttpGet("{nom}")]
        public User Register (string nom)
        {
            User usuario = new User();
            usuario.Id = valorId;
            usuario.Nombre = nom;
            usuario.Password = "pass";
            usuario.IdToken = valorIdToken;
            return usuario;
        }

        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.Id == id);
        }
    }
}
