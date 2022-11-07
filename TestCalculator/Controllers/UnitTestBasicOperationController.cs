using NUnit.Framework;
using System;
using System.Collections.Generic;
using WebApplication2.Entities;
using WebApplication2.Services.BasicOperationsImplementation;

namespace TestCalculator
{
    public class Tests
    {
        private RequestOperations _request;
        private ResponseOperations _response;
        double numberOne = -44;
        double numberTwo = 125;

        [SetUp]
        public void Setup()
        {
            
            _request = new RequestOperations();
            _request.ValuesBasicOperations = new List<double>();
            _request.ValuesBasicOperations.Add(numberOne);
            _request.ValuesBasicOperations.Add(numberTwo);
        }

        [Test]
        public void PostAdditionTest()
        {
            BasicOperations calculator = new BasicOperations(new Addition());
            _response = calculator.Execute(_request);
            Assert.AreEqual(numberOne + numberTwo, _response.Total);
            Assert.AreNotEqual(numberOne / numberTwo, _response.Total);
        }

        [Test]
        public void PostSubstractionTest()
        {
            BasicOperations calculator = new BasicOperations(new Substraction());
            _response = calculator.Execute(_request);
            Assert.AreEqual(numberOne - numberTwo, _response.Total);
            Assert.AreNotEqual(numberOne * numberTwo, _response.Total);
        }

        [Test]
        public void PostMultiplicationTest()
        {
            BasicOperations calculator = new BasicOperations(new Multiplication());
            _response = calculator.Execute(_request);
            Assert.AreEqual(numberOne * numberTwo, _response.Total);
            Assert.AreNotEqual(numberOne / numberTwo, _response.Total);
        }

        [Test]
        public void PostDivisionTest()
        {
            BasicOperations calculator = new BasicOperations(new Division());
            _response = calculator.Execute(_request);
            Assert.AreEqual(numberOne / numberTwo, _response.Total);
            Assert.AreNotEqual(numberOne + numberTwo, _response.Total);
        }
    }
}