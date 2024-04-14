using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapp.Services;
using webapp.ViewModels;

namespace webapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientiController : ControllerBase
    {
        public PacientiService _pacientiService;

        public PacientiController(PacientiService pacientiService)
        {
            _pacientiService = pacientiService;
        }

        [HttpPost("add-pacienti")]
        public IActionResult AddPacienti([FromBody] PacientiVM pacienti) 
        {
            _pacientiService.AddPacienti(pacienti);
            return Ok();
        }

        [HttpGet("get-all-pacienti")]
        public IActionResult GetAllPacienti() 
        {
            var allPacienti = _pacientiService.GetAllPacienti();
            return Ok(allPacienti);
        }

        [HttpGet("get-pacienti-by-id/{id}")]
        public IActionResult GetPacientiById(int id)
        {
            var pacienti = _pacientiService.GetPacientiById(id);
            return Ok(pacienti);
        }

        [HttpPut("update-pacient-by-id/{id}")]
        public IActionResult UpdatePacientById(int id, [FromBody]PacientiVM pacienti) 
        {
            var updatedPacient = _pacientiService.UpdatePacientiById(id, pacienti);
            return Ok(updatedPacient);
        }

        [HttpDelete("delete-pacienti-by-id/{id}")]
        public IActionResult DeletePacientiById(int id) 
        {
            _pacientiService.DeletePacientiById(id);
            return Ok();
        }
    }
}
