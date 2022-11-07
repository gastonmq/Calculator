using WebApplication2.Entities;

namespace WebApplication2.Services.BasicOperationsImplementation
{
    public class Substraction: IOperations
    {
        public ResponseOperations Calculate(RequestOperations request)
        {
            try
            {
                for(int i = 1; i < request.ValuesBasicOperations.Count; i++)
                {
                    request.ValuesBasicOperations[i] = request.ValuesBasicOperations[i] * -1;
                }
                ResponseOperations response = new ResponseOperations();
                response.Total = 0;
                foreach (double value in request.ValuesBasicOperations)
                {
                    response.Total = response.Total + value;
                }
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
