using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace ConsoleApp1
{
    class PersonTest
    {
        Person person;
        [SetUp]
        public void init()
        {
            person = new Person();
        }
        [Test]
        public void TestException()
        {
            Assert.Throws<MissingFieldException>(TestName);
        }
        [Test]
        public void TestExceptionLambda()
        {
            person.Fname = "Bhargav";
            person.Mname = "Krishna";
            Assert.Throws<MissingFieldException>(() => person.GetFullName());
        }
        private void TestName()
        {
            person.Fname = "Bhargav";
            person.Mname = "Krishna";
            string res = person.GetFullName();
        }
        [Test]
        public void TestFullName()
        {
            person.Fname = "Bhargav";
            person.Mname = "P";
            person.Lname = "Krishna";
            Assert.AreEqual("Bhargav P Krishna", person.GetFullName());
        }
    }
}
