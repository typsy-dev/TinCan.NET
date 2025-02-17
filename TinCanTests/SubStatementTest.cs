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

    [TestClass]
    public class SubStatementTest
    {
        [TestInitialize]
        public void Init()
        {
            //Console.WriteLine("Running " + TestContext.CurrentContext.Test.FullName);
        }

        [TestMethod]
        public void TestEmptyCtr()
        {
            var obj = new SubStatement();
            //Assert.IsInstanceOf<SubStatement>(obj);
            Assert.IsInstanceOfType(obj, new SubStatement().GetType());
            Assert.IsNull(obj.actor);
            Assert.IsNull(obj.verb);
            Assert.IsNull(obj.target);
            Assert.IsNull(obj.result);
            Assert.IsNull(obj.context);

            //StringAssert.AreEqualIgnoringCase("{\"objectType\":\"SubStatement\"}", obj.ToJSON());
            Assert.AreEqual("{\"objectType\":\"SubStatement\"}", obj.ToJSON(), true);
        }

        [TestMethod]
        public void TestJObjectCtrNestedSubStatement()
        {
            JObject cfg = new JObject();
            cfg.Add("actor", Support.agent.ToJObject());
            cfg.Add("verb", Support.verb.ToJObject());
            cfg.Add("object", Support.subStatement.ToJObject());

            var obj = new SubStatement(cfg);
            //Assert.IsInstanceOf<SubStatement>(obj);
            Assert.IsInstanceOfType(obj, new SubStatement().GetType());
            Assert.IsNull(obj.target);
        }
    }
}
