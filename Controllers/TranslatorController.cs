using Microsoft.AspNetCore.Mvc;
using TranslatorApi.Services;

namespace TranslatorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TranslatorController : ControllerBase
    {
        private readonly TranslatorService _translator;

        public TranslatorController(TranslatorService translator)
        {
            _translator = translator;
        }

        [HttpPost("translate")]
        public IActionResult Translate([FromBody] string text)
        {
            return Ok(_translator.Translate(text));
        }

        [HttpPost("restore")]
        public IActionResult Restore([FromBody] string text)
        {
            return Ok(_translator.Restore(text));
        }
    }
}