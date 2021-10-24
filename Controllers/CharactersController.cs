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
    public class CharactersController : ControllerBase
    {
        private readonly PersonajeContext _context;

        public CharactersController(PersonajeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<string> Characters()
        {
            var personajes = from m in _context.Personaje select m;

            List<string> nombres = new List<string>();

            foreach (var p in personajes.ToList())
            {
                string arreglo = p.Nombre + " " + p.Imagen;
                nombres.Add(arreglo);
            }
            return nombres;
        }


        
        //Actualizar
        // PUT: api/Characters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PostPersonaje(string id, Personaje personaje)
        {
            if (id != personaje.Nombre)
            {
                return BadRequest();
            }

            _context.Entry(personaje).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonajeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Characters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Personaje>> PostPersonaje(Personaje personaje)
        {
            _context.Personaje.Add(personaje);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PersonajeExists(personaje.Nombre))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("MostrarImagenNombre", new { id = personaje.Nombre }, personaje);
        }

        // DELETE: api/Characters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonaje(string id)
        {
            var personaje = await _context.Personaje.FindAsync(id);
            if (personaje == null)
            {
                return NotFound();
            }

            _context.Personaje.Remove(personaje);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonajeExists(string id)
        {
            return _context.Personaje.Any(e => e.Nombre == id);
        }
    }
}
