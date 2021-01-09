using System.Net.Cache;
using dotNetTips.Utility.Standard.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Utility.Standard.Common.Tests
{
    [TestClass]
    public class EnumHelperTests
    {

        [TestMethod]
        public void AddToPersonCollectionTest()
        {
            var result = EnumHelper.GetEnumValues<RequestCacheLevel>(false, false);

            Assert.IsTrue(result.HasItems());

            result = EnumHelper.GetEnumValues<HttpCacheAgeControl>(true, false);

            Assert.IsTrue(result.HasItems());

            result = EnumHelper.GetEnumValues<HttpCacheAgeControl>(false, true);

            Assert.IsTrue(result.HasItems());

            result = EnumHelper.GetEnumValues<HttpCacheAgeControl>(true, true);

            Assert.IsTrue(result.HasItems());
        }

    }
}
