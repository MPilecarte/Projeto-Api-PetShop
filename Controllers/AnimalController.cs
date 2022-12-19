using System;
using ApiPetShop.Models;
using ApiPetShop.Models.Enum;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiPetShop.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic ;

namespace ApiPetShop.Controller
{
    [ApiController]
    [Route("[Controller]")]

    public class AnimalController : ControllerBase
    {
        private readonly DataContext _context;

        public AnimalController(DataContext context)
        {
            _context = context;
        }


        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try{
                List<Animal> lista = await _context.Animais.ToListAsync();
                return Ok(lista);
            }
            catch(Exception ex){
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            try{
                Animal a = await _context.Animais
                    .FirstOrDefaultAsync(aBusca => aBusca.id == id);

                return Ok(a);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Post")]
        public async Task<IActionResult> AddAnimal(Animal novoAnimal)
        {
            try{
                if(novoAnimal.RGA == null)
                {
                    throw new Exception("Não é possivel inserir um novo animai sem sua indentificação(RGA)!");
                }
                await _context.Animais.AddAsync(novoAnimal);
                await _context.SaveChangesAsync();

                return Ok(novoAnimal);
            }
            catch (Exception ex){
                return BadRequest(ex.Message);
            }
        }


        [HttpPut]
        public async Task<IActionResult> Update(Animal novoAnimal)
        {
            try{
                if(novoAnimal.RGA == null)
                {
                    throw new Exception("Não é possivel inserir um novo animai sem sua indentificação(RGA)!");
                }
                _context.Animais.Update(novoAnimal);
                int linhasAfetadas= await _context.SaveChangesAsync();
                return Ok(linhasAfetadas);
            }
            catch (Exception ex){
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete (int id)
        {
            try{
                Animal aRemover = await _context.Animais
                    .FirstOrDefaultAsync(a => a.id == id);
                    _context.Animais.Remove(aRemover);
                    int linhasAfetadas = await _context.SaveChangesAsync();
                return Ok(linhasAfetadas);
            }
            catch (Exception ex){
                return BadRequest(ex.Message);
            }
        }

    }
}