﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Entities;
using WebApplication2.Services.BasicOperationsImplementation;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicOperationsController : ControllerBase
    {
        [HttpPost("Addition")]
        public ResponseOperations PostAddition([FromBody] RequestOperations request)
        {
            try
            {
                ResponseOperations response;
                BasicOperations calculator = new BasicOperations(new Add());
                response = calculator.Execute(request);
                return response;
            }
            catch (Exception)
            {

                throw;
            }
        }

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
            catch (Exception)
            {

                throw;
            }
        }

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
            catch (Exception)
            {

                throw;
            }
        }

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
            catch (Exception)
            {

                throw;
            }            
        }
    }
}
