using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.Serialization;

namespace dotNetTips.Tips.Utility.Standard.Tests.Serialization
{
    [TestClass]
    public class JsonSerializerTests
    {
        [TestMethod]
        public void SerializingPersonToJsonTest()
        {
            var person = RandomData.GeneratePerson<PersonProper>();

            var json = dotNetTips.Utility.Standard.Serialization.JsonSerializer.Serialize(person);

            Debug.WriteLine(json);

            Assert.IsTrue(string.IsNullOrEmpty(json) == false);
        }

        [TestMethod]
        public void SerializingPersonCollectionToJsonTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToList();

            var json = dotNetTips.Utility.Standard.Serialization.JsonSerializer.Serialize(people);

            Debug.WriteLine(json);

            Assert.IsTrue(string.IsNullOrEmpty(json) == false);
        }

        [TestMethod]
        public void DeserializingPersonFromJsonTest()
        {
            var person = RandomData.GeneratePerson<PersonProper>();

            var json = dotNetTips.Utility.Standard.Serialization.JsonSerializer.Serialize(person);

            Assert.IsTrue(dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize<PersonProper>(json) != null);
        }

        [TestMethod]
        public void JsonEqualsTest()
        {
            var person1 = RandomData.GeneratePerson<PersonProper>().ToJson();
            var person2 = RandomData.GeneratePerson<PersonProper>().ToJson();

            Assert.IsTrue(JsonSerializer.JsonEqual(person1, person1));
            Assert.IsFalse(JsonSerializer.JsonEqual(person1, person2));
        }

        [TestMethod]
        public void DeserializingPersonCollectionFromJsonTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToList();

            var json = dotNetTips.Utility.Standard.Serialization.JsonSerializer.Serialize(people);

            var peopleFromJson = dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize< List<PersonProper>>(json);


            Assert.IsTrue(peopleFromJson!= null);

            Assert.IsTrue(peopleFromJson.Count > 0);
        }
    }
}
