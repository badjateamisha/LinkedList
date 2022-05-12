using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Tests
{
    [TestClass()]
    public class LLMethodsTests
    {
        [TestMethod()]
        public void SearchTest()
        {
            LLMethods<int> lLMethods = new();
            lLMethods.AddNodeToFront(70);
            lLMethods.AddNodeToFront(30);
            lLMethods.AddNodeToFront(56);
            lLMethods.SearchMethod(30);
            Assert.AreEqual(true, lLMethods.SearchMethod(30));

        }
    }
}