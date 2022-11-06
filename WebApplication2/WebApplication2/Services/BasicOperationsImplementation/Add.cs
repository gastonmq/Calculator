using WebApplication2.Entities;

namespace WebApplication2.Services.BasicOperationsImplementation
{
    public class Add: IBasicOperations
    {
        public ResponseOperations Calculate(RequestOperations request)
        {
            try
            {
                ResponseOperations response = new ResponseOperations();
                response.Total = 0;
                foreach (double value in request.ValuesBasicOperations)
                {
                    response.Total = response.Total + value;
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
