using WebApplication2.Entities;

namespace WebApplication2.Services
{
    public interface IBasicOperations
    {
        ResponseOperations Calculate(RequestOperations request);
    }
}
