using NUnit.Framework;
using System;
using UserRegistrationMstest;

namespace UserRegistrationTest
{
    public class Tests
    {
        Validation validation;
        [SetUp]
        public void Setup()
        {
            validation = new Validation();
        }

        [Test]
        public void ValidFirst()
        {
            string expected = "First Name is Valid";
            string name = "Ravi";
            string result = validation.ValidFirstName(name);
            Assert.AreEqual(expected, result);
        }
    }

 
}