using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DemoNuGet.Tests
{
    [TestFixture]
    public class HelloWorldTests
    {
        [Test]
        public void SayHello_ReturnsProperString()
        {
            var result = HelloWorld.SayHello("Dennis");
            Assert.That(result, Is.EqualTo("Hello Dennis"));
        }
    }
}
