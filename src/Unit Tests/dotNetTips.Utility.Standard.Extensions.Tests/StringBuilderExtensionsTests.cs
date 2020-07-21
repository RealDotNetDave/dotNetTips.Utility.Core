using System.Text;
using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Utility.Standard.Extensions.Tests
{
    [TestClass]
    public class StringBuilderExtensionsTests
    {
        [TestMethod]
        public void AppendBytesTest()
        {
            var sb = new StringBuilder();
            var byteArray = RandomData.GenerateByteArray(sizeInKb: 1);
            sb.AppendBytes(byteArray);

            Assert.IsTrue(sb.Length > 50);
        }

        [TestMethod]
        public void AppendJoinTest01()
        {
            var sb = new StringBuilder();
            var values = RandomData.GenerateWords(count: 5, minLength: 5, maxLength: 7);

            sb.AppendValues(", ", values);

            Assert.IsTrue(sb.Length > 10);
        }


        [TestMethod]
        public void AppendJoinTest02()
        {
            var sb = new StringBuilder();
            var values = RandomData.GenerateCoordinateCollection<Coordinate>(count: 5);

            sb.AppendValues(", ", values, (person) =>
             {
                 sb.Append(person.X);
                 sb.Append(ControlChars.Colon);
                 sb.Append(person.Y);
             });

            Assert.IsTrue(sb.Length > 100);
        }
    }
}
