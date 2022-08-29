using Microsoft.AspNetCore.Mvc;
using SPZ.BusinessLogic.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SPZ.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AliasesController : ControllerBase
    {
        private readonly IAliasesService _aliasesService;

        public AliasesController(IAliasesService aliasesService)
        {
            _aliasesService = aliasesService;
        }

        [HttpGet("with-length/{length}")]
        public IActionResult GetAliasesShorterThan(int length)
        {
            try
            {
                var result = _aliasesService.GetAlliasesWithCertainLength(length);
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        

        
    }
}
