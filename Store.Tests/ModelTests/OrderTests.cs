using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store;
using System;
using System.Collections.Generic;

namespace Store.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
    Order newOrder = new Order();
    Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}