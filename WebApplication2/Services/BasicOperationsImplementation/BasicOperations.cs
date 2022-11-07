using WebApplication2.Services;

namespace WebApplication2.Entities
{
    public class BasicOperations
    {
        //This Helper is needed for strategy.
        //Controllers of operations will call this execute method to perform the basic operations
        private IOperations calculator;
        public BasicOperations(IOperations operation)
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
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
