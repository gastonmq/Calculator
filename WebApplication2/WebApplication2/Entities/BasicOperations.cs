using WebApplication2.Services;

namespace WebApplication2.Entities
{
    public class BasicOperations
    {
        private IBasicOperations calculator;
        public BasicOperations(IBasicOperations operation)
        {
            calculator = operation;
        }
        public ResponseOperations Execute(RequestOperations request)
        {
            try
            {
                ResponseOperations response = new ResponseOperations();
                return response = calculator.Calculate(request);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
