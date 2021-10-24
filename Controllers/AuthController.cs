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
    [Route("[controller]/[Action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private static int valorId = 100;
        private static int valorIdToken = 1000;
        private readonly UsuarioContext _context;

        public AuthController(UsuarioContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public User Login(string nombre, string password)
        {

            var result = from m in _context.User select m;

            User usuario = new User();

            foreach(var p in result.ToList())
            {
                if (p.Nombre == nombre && p.Password == password)
                {
                    return p;
                }
            }
            return usuario;
        }
/*
        [HttpPost]
        public async Task<ActionResult<User>> Register(User usuario)
        {
            _context.User.Add(usuario);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserExists(usuario.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("Registrar", new { id = usuario.Id }, usuario);
        }
*/

        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.Id == id);
        }

    
    }
}
