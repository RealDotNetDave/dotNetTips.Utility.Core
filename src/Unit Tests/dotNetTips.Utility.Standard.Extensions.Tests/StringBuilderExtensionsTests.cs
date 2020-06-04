using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace dotNetTips.Utility.Standard.Extensions.Tests
{
    [TestClass]
    public class StringBuilderExtensionsTests
    {
        [TestMethod]
        public void AppendBytesTest()
        {
            var sb = new StringBuilder();
            var byteArray = RandomData.GenerateByteArray(1);
            sb.AppendBytes(byteArray);

            Assert.IsTrue(sb.Length > 50);
        }

        [TestMethod]
        public void AppendJoinTest01()
        {
            var sb = new StringBuilder();
            var values = RandomData.GenerateWords(5, 5, 7);

            sb.AppendValues(", ", values);

            Assert.IsTrue(sb.Length > 10);
        }


        [TestMethod]
        public void AppendJoinTest02()
        {
            var sb = new StringBuilder();
            var values = RandomData.GenerateCoordinateCollection<Coordinate>(5);

            sb.AppendValues(", ",values, (sb, person) =>
            {
                sb.Append(person.X);
                sb.Append(ControlChars.Colon);
                sb.Append(person.Y);
            });

            Assert.IsTrue(sb.Length > 100);
        }
    }
}
