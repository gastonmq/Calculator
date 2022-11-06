using WebApplication2.Entities;

namespace WebApplication2.Services.BasicOperationsImplementation
{
    public class Multiplication: IBasicOperations
    {
        public ResponseOperations Calculate(RequestOperations request)
        {
            try
            {
                ResponseOperations response = new ResponseOperations();
                response.Total = 1;
                foreach (double value in request.ValuesBasicOperations)
                {
                    response.Total =  value * response.Total;
                }
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
