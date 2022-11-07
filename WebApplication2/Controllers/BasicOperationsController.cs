using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Entities;
using WebApplication2.Services.BasicOperationsImplementation;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicOperationsController : ControllerBase
    {
        //Controllers of Basic operations.
        //Feel free to add more basic operations
        //Create other controller for complex operations


        //Post to Addition: Receive RequestOperations return ResponseOperations
        [HttpPost("Addition")]
        public ResponseOperations PostAddition([FromBody] RequestOperations request)
        {
            try
            {
                ResponseOperations response;
                BasicOperations calculator = new BasicOperations(new Addition());
                response = calculator.Execute(request);
                return response;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //Post to Substraction: Receive RequestOperations return ResponseOperations
        [HttpPost("Substraction")]
        public ResponseOperations PostSubstraction([FromBody] RequestOperations request)
        {
            try
            {
                ResponseOperations response;
                BasicOperations calculator = new BasicOperations(new Substraction());
                response = calculator.Execute(request);
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Post to Multiplication: Receive RequestOperations return ResponseOperations
        [HttpPost("Multiplication")]
        public ResponseOperations PostMultiplication([FromBody] RequestOperations request)
        {
            try
            {
                ResponseOperations response;
                BasicOperations calculator = new BasicOperations(new Multiplication());
                response = calculator.Execute(request);
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Post to Division: Receive RequestOperations return ResponseOperations
        [HttpPost("Division")]
        public ResponseOperations PostDivision([FromBody] RequestOperations request)
        {
            try
            {
                ResponseOperations response;
                BasicOperations calculator = new BasicOperations(new Division());
                response = calculator.Execute(request);
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }
    }
}
