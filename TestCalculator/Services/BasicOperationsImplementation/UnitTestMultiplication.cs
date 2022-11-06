using NUnit.Framework;
using System.Collections.Generic;
using WebApplication2.Entities;

namespace TestCalculator.Services.BasicOperationsImplementation
{
    public class UnitTestMultiplication
    {
        private RequestOperations _request;
        private ResponseOperations _response;
        double numberOne = -44;
        double numberTwo = 125;

        [SetUp]
        public void Setup()
        {
            _response = new ResponseOperations();
            _response.Total = 1;
            _request = new RequestOperations();
            _request.ValuesBasicOperations = new List<double>();
            _request.ValuesBasicOperations.Add(numberOne);
            _request.ValuesBasicOperations.Add(numberTwo);
        }

        [Test]
        public void CalculateTest()
        {
            foreach (double value in _request.ValuesBasicOperations)
            {
                _response.Total = _response.Total * value;
            }
            Assert.AreEqual(numberOne * numberTwo, _response.Total);
        }
    }
}
