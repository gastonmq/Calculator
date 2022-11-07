using WebApplication2.Entities;

namespace WebApplication2.Services
{
    public interface IOperations
    {
        //Interface of strategy
        //The name is "Operations" because you can add logic for complex and basic operations
        ResponseOperations Calculate(RequestOperations request);
    }
}
