using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DisciplinaController : ControllerBase
    {
        public List<Disciplina> Disciplinas = new List<Disciplina>() {
            new Disciplina() {
                Id = 1,
                Nome = "Português",
                ProfessorId = 1
            },
            new Disciplina() {
                Id = 1,
                Nome = "Matematica",
                ProfessorId = 2
            },
            new Disciplina() {
                Id = 1,
                Nome = "Inglês",
                ProfessorId = 3
            },
        };
        
        public DisciplinaController() { }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Disciplinas);            
        }
    }
}