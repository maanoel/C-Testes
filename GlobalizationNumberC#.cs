using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TESTESRest
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Get(string firstNumber, string secondNumber) 
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber)) {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");
        }

        private bool IsNumeric(string number) 
        {
            double formattedNumber;

            bool isNumber = double.TryParse(
               number,
               System.Globalization.NumberStyles.Any,
               System.Globalization.NumberFormatInfo.InvariantInfo,
               out formattedNumber
              );

            return isNumber;
        }

        private decimal ConvertToDecimal(string number)
        {
            return Convert.ToDecimal(number);
        }
    }
}
