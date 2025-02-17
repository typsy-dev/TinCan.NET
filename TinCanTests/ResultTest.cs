﻿/*
    Copyright 2015 Rustici Software

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
    public class ResultTest
    {
        [TestMethod]
        public void TestEmptyCtr()
        {
            var obj = new Result();
            //Assert.IsInstanceOf<Result>(obj);
            Assert.IsInstanceOfType(obj, new Result().GetType());
            Assert.IsNull(obj.completion);
            Assert.IsNull(obj.success);
            Assert.IsNull(obj.response);
            Assert.IsNull(obj.duration);
            Assert.IsNull(obj.score);
            Assert.IsNull(obj.extensions);

            //StringAssert.AreEqualIgnoringCase("{}", obj.ToJSON());
            Assert.AreEqual("{}", obj.ToJSON(), true);
        }

        [TestMethod]
        public void TestJObjectCtr()
        {
            var cfg = new JObject();
            cfg.Add("completion", true);
            cfg.Add("success", true);
            cfg.Add("response", "Yes");

            var obj = new Result(cfg);
            //Assert.IsInstanceOf<Result>(obj);
            Assert.IsInstanceOfType(obj, new Result().GetType());
            //Assert.That(obj.completion, Is.EqualTo(true));
            Assert.AreEqual(obj.completion, true);
            //Assert.That(obj.success, Is.EqualTo(true));
            Assert.AreEqual(obj.success, true);
            //Assert.That(obj.response, Is.EqualTo("Yes"));
            Assert.AreEqual(obj.response, "Yes");
        }

        [TestMethod]
        public void TestStringOfJSONCtr()
        {
            var json = "{\"success\": true, \"completion\": true, \"response\": \"Yes\"}";
            var strOfJson = new StringOfJSON(json);

            var obj = new Result(strOfJson);
            //Assert.IsInstanceOf<Result>(obj);
            Assert.IsInstanceOfType(obj, new Result().GetType());
            //Assert.That(obj.success, Is.EqualTo(true));
            //Assert.That(obj.completion, Is.EqualTo(true));
            //Assert.That(obj.response, Is.EqualTo("Yes"));
            Assert.AreEqual(obj.completion, true);
            Assert.AreEqual(obj.success, true);
            Assert.AreEqual(obj.response, "Yes");
        }
    }
}
