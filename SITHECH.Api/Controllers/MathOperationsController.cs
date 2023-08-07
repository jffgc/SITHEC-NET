using Microsoft.AspNetCore.Mvc;
using SITHECH.Api.Helpers;

namespace SITHECH.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathOperationsController : ControllerBase
    {
        [HttpPost("Operations/{value1}/{mathOperator}/{value2}")]
        public IActionResult Post(float value1, int mathOperator, float value2)
        {
            try
            {
                (bool flag, string message) = Helper.ValidateOperator(mathOperator);
                if (flag == false)
                {
                    throw new Exception(message);
                }
                string result = Helper.Calculate(value1, mathOperator, value2);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetHeaders")]
        public IActionResult GetHeaders([FromHeader] float value1, [FromHeader] int mathoperator, [FromHeader] float value2)
        {
            try
            {
                (bool flag, string message) = Helper.ValidateOperator(mathoperator);
                if (flag == false)
                {
                    throw new Exception(message);
                }
                string result = Helper.Calculate(value1, mathoperator, value2);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       
    }
}
