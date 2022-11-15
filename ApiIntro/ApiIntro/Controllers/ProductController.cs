using Microsoft.AspNetCore.Mvc;

namespace ApiIntro.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetNameById(int id)
        {
            string name = "Narmin" + id;
            return Ok(name);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<string> names = new List<string>() { "Seid", "Orxan", "Narmin", "Fidan", "Seadet" };
            return Ok(names);
        }
        
    }
}
