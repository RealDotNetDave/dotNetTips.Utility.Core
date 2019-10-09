using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Tips.Utility.Standard.Tests.Serialization
{
    [TestClass]
    public class JsonSerializerTests
    {
        [TestMethod]
        public void TestSerializingPersonToJson()
        {
            var person = RandomData.GeneratePerson<PersonProper>();

            var json = dotNetTips.Utility.Standard.Serialization.JsonSerializer.Serialize(person);

            Debug.WriteLine(json);

            Assert.IsTrue(string.IsNullOrEmpty(json) == false);
        }

        [TestMethod]
        public void TestSerializingPersonCollectionToJson()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToList();

            var json = dotNetTips.Utility.Standard.Serialization.JsonSerializer.Serialize(people);

            Debug.WriteLine(json);

            Assert.IsTrue(string.IsNullOrEmpty(json) == false);
        }

        [TestMethod]
        public void TestDeserializingPersonFromJson()
        {
            var person = RandomData.GeneratePerson<PersonProper>();

            var json = dotNetTips.Utility.Standard.Serialization.JsonSerializer.Serialize(person);

            Assert.IsTrue(dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize<PersonProper>(json) != null);
        }

        [TestMethod]
        public void TestDeserializingPersonCollectionFromJson()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToList();

            var json = dotNetTips.Utility.Standard.Serialization.JsonSerializer.Serialize(people);

            var peopleFromJson = dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize< List<PersonProper>>(json);


            Assert.IsTrue(peopleFromJson!= null);

            Assert.IsTrue(peopleFromJson.Count > 0);
        }
    }
}
