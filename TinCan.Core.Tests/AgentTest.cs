﻿/*
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
namespace TinCanTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Newtonsoft.Json.Linq;
    using TinCan;
    using TinCan.Json;

    [TestClass]
    public class AgentTest
    {
        [TestMethod]
        public void TestEmptyCtr()
        {
            var obj = new Agent();
            Assert.IsInstanceOfType(obj, new Agent().GetType());
            Assert.IsNull(obj.mbox);

            Assert.AreEqual("{\"objectType\":\"Agent\"}", obj.ToJSON(), true);
        }

        [TestMethod]
        public void TestJObjectCtr()
        {
            var mbox = "mailto:tincancsharp@tincanapi.com";

            var cfg = new JObject();
            cfg.Add("mbox", mbox);

            var obj = new Agent(cfg);
            //Assert.IsInstanceOf<Agent>(obj);
            Assert.IsInstanceOfType(obj, new Agent().GetType());
            //Assert.That(obj.mbox, Is.EqualTo(mbox));
            Assert.AreEqual(obj.mbox, mbox);
        }

        [TestMethod]
        public void TestStringOfJSONCtr()
        {
            var mbox = "mailto:tincancsharp@tincanapi.com";

            var json = "{\"mbox\":\"" + mbox + "\"}";
            var strOfJson = new StringOfJSON(json);

            var obj = new Agent(strOfJson);
            //Assert.IsInstanceOf<Agent>(obj);
            Assert.IsInstanceOfType(obj, new Agent().GetType());
            //Assert.That(obj.mbox, Is.EqualTo(mbox));
            Assert.AreEqual(obj.mbox, mbox);
        }
    }
}
