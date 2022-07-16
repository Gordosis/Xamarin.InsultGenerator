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
    public class MultiInsultTest
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
        [InlineData(87)]
        public void TestMultiInsultReturnsValue(int x)
        {
            var vm = new MultiInsultView();

            Assert.NotEmpty(vm.GetNumInsult(x));
        }
    }


}

