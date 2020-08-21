using System;
using System.IO;
using NUnit.Framework;
using csharp_dsa.Solutions;

namespace csharp_dsa.tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void HelloWorld_ShouldPrint()
        {
            var expected = @"Hello World!";
            var actual = "";
            using(var sw = new StringWriter()) 
            {
                Console.SetOut(sw);
                HelloWorld.Main();
                actual = sw.ToString();
            }
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}