using WebApplication2.Entities;

namespace WebApplication2.Services
{
    public interface IOperations
    {
        ResponseOperations Calculate(RequestOperations request);
    }
}
