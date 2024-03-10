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

        [HttpGet("GetDefaultNameKeys")]
        [Authorize]
        public async Task<IActionResult> GetDefaultNameKeys(string InitialValue)
        {
            try
            {
                var addInitials = await _appDBContext.PatReg_Shortkeys
            .Where(s => s.Initial == InitialValue)
            .ToListAsync();

                return Ok(addInitials);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpGet("GetInitialList")]
        [Authorize]
        public async Task<IActionResult> GetInitialList()
        {
            try
            {
                var addInitials = await _appDBContext.PatReg_Shortkeys.ToListAsync();
                return Ok(addInitials);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpGet("GetRelationList")]
        [Authorize]
        public async Task<IActionResult> GetRelationList()
        {
            try
            {
                var addRelation = await _appDBContext.PatReg_Shortkeys
                     .Where(s => s.Relation != null && s.Relation.Trim() != "")
                     .Select(s => s.Relation)
                     .Distinct()
                     .ToListAsync();
                return Ok(addRelation);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpGet("GetAgeTypeList")]
        [Authorize]
        public async Task<IActionResult> GetAgeTypeList()
        {
            try
            {
                var addAgeType = await _appDBContext.PatReg_Shortkeys
                     .Where(s => s.Years != null && s.Years.Trim() != "")
                     .Select(s => s.Years)
                     .Distinct()
                     .ToListAsync();
                return Ok(addAgeType);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpGet("GetGenderList")]
        [Authorize]
        public async Task<IActionResult> GetGenderList()
        {
            try
            {
                var addGender = await _appDBContext.PatReg_Shortkeys
                     .Where(s => s.Gender != null && s.Gender.Trim() != "")
                     .Select(s => s.Gender)
                     .Distinct()
                     .ToListAsync();
                return Ok(addGender); ;
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
