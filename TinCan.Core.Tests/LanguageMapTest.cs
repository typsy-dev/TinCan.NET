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
    using TinCan;

    [TestClass]
    public class LanguageMapTest
    {
        [TestMethod]
        public void TestEmptyCtr()
        {
            LanguageMap obj = new LanguageMap();
            //Assert.IsInstanceOf<LanguageMap>(obj);
            Assert.IsInstanceOfType(obj, new LanguageMap().GetType());
        }
    }
}
