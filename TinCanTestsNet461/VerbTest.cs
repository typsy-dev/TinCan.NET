/*
    Copyright 2014 Rustici Software

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.
*/
using System;
// Newtonsoft.Json.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using TinCan;
using TinCan.Json;

namespace TinCanTestsNet461
{
    [TestClass]
    public class VerbTest
    {
        [TestMethod]
        public void TestEmptyCtr()
        {
            Verb obj = new Verb();
            //Assert.IsInstanceOf<Verb>(obj);
            Assert.IsInstanceOfType(obj, new Verb().GetType());
            Assert.IsNull(obj.id);
            Assert.IsNull(obj.display);

            //StringAssert.AreEqualIgnoringCase("{}", obj.ToJSON());
            Assert.AreEqual("{}", obj.ToJSON(), true);
        }

        [TestMethod]
        public void TestJObjectCtr()
        {
            String id = "http://adlnet.gov/expapi/verbs/experienced";

            JObject cfg = new JObject();
            cfg.Add("id", id);

            Verb obj = new Verb(cfg);
            //Assert.IsInstanceOf<Verb>(obj);
            Assert.IsInstanceOfType(obj, new Verb().GetType());
            //Assert.That(obj.ToJSON(), Is.EqualTo("{\"id\":\"" + id + "\"}"));
            Assert.AreEqual("{\"id\":\"" + id + "\"}", obj.ToJSON(), true);
        }

        [TestMethod]
        public void TestStringOfJSONCtr()
        {
            String id = "http://adlnet.gov/expapi/verbs/experienced";
            String json = "{\"id\":\"" + id + "\"}";
            StringOfJSON strOfJson = new StringOfJSON(json);

            Verb obj = new Verb(strOfJson);
            //Assert.IsInstanceOf<Verb>(obj);
            Assert.IsInstanceOfType(obj, new Verb().GetType());
            //Assert.That(obj.ToJSON(), Is.EqualTo(json));
            Assert.AreEqual(json, obj.ToJSON(), true);
        }
    }
}
