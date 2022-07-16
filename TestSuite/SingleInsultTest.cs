using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Trash;
using Trash.Droid;
using Trash.Views;
using Trash.ViewModels;

namespace TestSuite
{
    [TestClass]
    public class SingleInsultTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }

        /*[TestMethod]
        //[DataSource("Name")]
        [DynamicData("name")]
        public void TestSingleInsultReturnsValue()
        {
            var vm = new SingleInsultView();
            string insult = "";
 
            string Insult = vm.GetInsult(insult);

            Assert.IsNotNull(Insult);
        }*/
    }
}
