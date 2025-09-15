using Microsoft.AspNetCore.Mvc;

namespace WebApiRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            //if (IsNumeric(secondNumber) && IsNumeric(secondNumber))
            //{
            //    var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);

            //    return Ok(sum.ToString());
            //}

            return BadRequest("Invalid Input");
        }

        //[HttpGet("sub/{firstNumber}/{secondNumber}")]
        //public IActionResult Subtraction(string firstNumber, string secondNumber)
        //{
        //    if (IsNumeric(secondNumber) && IsNumeric(secondNumber))
        //    {
        //        var sub = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);

        //        return Ok(sub.ToString());
        //    }

        //    return BadRequest("Invalid Input");
        //}
        //[HttpGet("multi/{firstNumber}/{secondNumber}")]
        //public IActionResult Multiplication(string firstNumber, string secondNumber)
        //{
        //    if (IsNumeric(secondNumber) && IsNumeric(secondNumber))
        //    {
        //        var multi = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);

        //        return Ok(multi.ToString());
        //    }

        //    return BadRequest("Invalid Input");
        //}
        //[HttpGet("div/{firstNumber}/{secondNumber}")]
        //public IActionResult Division(string firstNumber, string secondNumber)
        //{
        //    if (IsNumeric(secondNumber) && IsNumeric(secondNumber))
        //    {
        //        var div  = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);

        //        return Ok(div.ToString());
        //    }

        //    return BadRequest("Invalid Input");
        //}
        //[HttpGet("avg/{firstNumber}/{secondNumber}")]
        //public IActionResult Average(string firstNumber, string secondNumber)
        //{
        //    if (IsNumeric(secondNumber) && IsNumeric(secondNumber))
        //    {
        //        var avg = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber)) / 2;

        //        return Ok(avg.ToString());
        //    }

        //    return BadRequest("Invalid Input");
        //}
        //[HttpGet("square-root/{firstNumber}")]
        //public IActionResult SquareRoot(string firstNumber)
        //{
        //    if (IsNumeric(firstNumber))
        //    {
        //        var squareRoot = Math.Sqrt((double)ConvertToDecimal(firstNumber));

        //        return Ok(squareRoot.ToString());
        //    }

        //    return BadRequest("Invalid Input");
        //}
        //private bool IsNumeric(string strNumber)
        //{
        //    double number;
        //    bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
        //    return isNumber;
        //}

        //private decimal ConvertToDecimal(string strNumber)
        //{
        //    decimal decimalValue;
        //    if (decimal.TryParse(strNumber, out decimalValue)) 
        //    {
        //        return decimalValue;
        //    }
        //    return 0;
        //}

    }
}
