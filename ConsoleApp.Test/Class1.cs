using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApp;

namespace ConsoleApp.Test
{
    [TestFixture]
    public class Class1
    {
        [SetUp]
        public void SetupMethod()
        {
            System.Diagnostics.Debug.WriteLine("Starting test execution");
        }
        [TestCase]
        [Category("AdditionTests")]
        public void TestAdd()
        {
            Add objadd = new Add();
            int addition = objadd.AddValues(25, 35);
            Assert.AreEqual(60, addition);
        }
        [TestCase]
        [Category("AdditionTests")]
        public void TestAddFail()
        {
            Add objadd = new Add();
            int addition = objadd.AddValues(25, 35);
            Assert.AreEqual(6, addition);
        }
        [TestCase]
        [Category("GreaterTests")]
        public void TestAddGreater()
        {
            Add objadd = new Add();
            int addition = objadd.AddValues(25, 35);
            Assert.Greater(100, addition);
        }
        [TestCase]
        [Ignore("Skipping TestAddIgnore for Demo purpose")]
        public void TestAddIgnore()
        {
            Add objadd = new Add();
            int addition = objadd.AddValues(25, 35);
            Assert.Greater(100, addition);
        }
        [TestCase]
        public void TestAddException()
        {
            Assert.Throws<ArgumentException>(() => { throw new ArgumentException(); });
        }
    }
}
