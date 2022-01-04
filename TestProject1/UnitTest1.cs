using ClassLibrary2;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            var scanService = new Function1();
            scanService.Foo();
        }
    }
}