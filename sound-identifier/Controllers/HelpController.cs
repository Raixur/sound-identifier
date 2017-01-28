using Microsoft.AspNetCore.Mvc;

namespace SoundIdentifier.Controllers
{
    [Route("[controller]")]
    public class HelpController : Controller
    {
        [HttpGet]
        public IActionResult Help()
        {
            // TODO: Describe usage
            return new JsonResult("Help!");
        }
    }
}