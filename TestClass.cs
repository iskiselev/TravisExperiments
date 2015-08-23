using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravisExperiments
{
    using NUnit.Core;
    using NUnit.Framework;

    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
             Console.WriteLine("Test executed");
        }
    }
}
