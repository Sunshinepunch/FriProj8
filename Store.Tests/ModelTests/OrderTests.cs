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
    Order newOrder = new Order("test", "placeholder2", 4, "test");
    Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void CreateTitle_CreatesOrderWithTitle_String()
    {
    string title ="12 pies";
    string description = "13 apple pies";
    int price = 4;
    string duedate = "test";
    Order newOrder = new Order(title, description, price, duedate);
    string result = newOrder.OrderTitle;
    Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void CreateDescrip_CreatesOrderWithDescription_String()
    {
    string title ="12 pies";
    string description = "apple";
    int price = 4;
    string duedate = "test";
    Order newOrder = new Order(title, description, price, duedate);
    string result = newOrder.OrderDescription;
    Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void CreatePrice_CreatesOrderWithPrice_Int()
    {
    string title ="12 pies";
    string description = "apple";
    int price = 12;
    string duedate = "test";
    Order newOrder = new Order(title, description, price, duedate);
    int result = newOrder.OrderPrice;
    Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void CreateDate_CreatesOrderWithDate_String()
    {
    string title ="12 pies";
    string description = "apple";
    int price = 12;
    string duedate = "March 8th 2022";
    Order newOrder = new Order(title, description, price, duedate);
    string result = newOrder.OrderDate;
    Assert.AreEqual(duedate, result);
    }
  }
}