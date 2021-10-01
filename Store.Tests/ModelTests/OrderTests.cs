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
    Order newOrder = new Order("test", "placeholder2");
    Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void CreateName_CreatesOrderWithName_String()
    {
    string name ="12 pies";
    string description = "13 apple pies";
    Order newOrder = new Order(name, description);
    string result = newOrder.OrderName;
    Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void CreateName_CreatesOrderWithDescription_String()
    {
    string name ="12 pies";
    string description = "apple";
    Order newOrder = new Order(name, description);
    string result = newOrder.OrderDescription;
    Assert.AreEqual(description, result);
    }
  }
}