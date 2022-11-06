using WebApplication2.Entities;

namespace WebApplication2.Services.BasicOperationsImplementation
{
    public class Division: IBasicOperations
    {
        public ResponseOperations Calculate(RequestOperations request)
        {
            try
            {
                ResponseOperations response = new ResponseOperations();
                response.Total = request.ValuesBasicOperations[0];
                request.ValuesBasicOperations.RemoveAt(0);
                foreach (double value in request.ValuesBasicOperations)
                {
                    response.Total = response.Total / value;
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
