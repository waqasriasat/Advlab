using AdvLab_WebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdvLab_WebApi.Controllers
{
    [Route("API/Receptions")]
    [ApiController]
    public class ReceptionController : ControllerBase
    {
        
        private readonly AppDBContext _appDBContext;
        private readonly IConfiguration _configuration;

        public ReceptionController(AppDBContext appDBContext, IConfiguration configuration)
        {
            _appDBContext = appDBContext;
            _configuration = configuration;
        }
        [HttpGet("All")]
        [Authorize]
        public async Task<IActionResult> GetAllDescLab()
        {
            try
            {
                var descCashiers = await _appDBContext.DescCashiers.ToListAsync();
                var descLabs = await _appDBContext.DescLabs.ToListAsync();
                var patRegs = await _appDBContext.PatRegs.ToListAsync();

                var result = new
                {
                    DescCashiers = descCashiers,
                    DescLabs = descLabs,
                    PatRegs = patRegs
                };
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
