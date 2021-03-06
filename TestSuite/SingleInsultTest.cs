using System;
using Trash;
using Trash.Views;
using Trash.ViewModels;
using Xunit;
using Xunit.Extensions;
using Xamarin;
using Xamarin.Forms;


namespace TestSuite
{
    //[TestClass]
    public class SingleInsultTest
    {
        [Fact]
        public void TestMethod1()
        {
            Assert.True(true);
        }

        [Fact]
        public void TestMethod2()
        {
            Assert.False(false);
        }

        [Theory]
        [InlineData ("TestName")]
        public void TestSingleInsultReturnsValue(string insult)
        {
            var vm = new SingleInsultView();

            Assert.NotEmpty(vm.GetInsult(insult));
        }
    }
}
