using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store;
using System;
using System.Collections.Generic;

namespace Store.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
    Vendor newVendor = new Vendor("test", "test again");
    Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void ReturnName_CreatesVendorWithName_String()
    {
      string name = "Vendoro";
      Vendor newVendor = new Vendor("Vendoro", "placeholder");
      string result = newVendor.VendorName;
      Assert.AreEqual(name, result);
    }
     [TestMethod]
    public void ReturnDescription_CreatesVendorWithDescription_String()
    {
      string description = "Pastry Store Owner";
      Vendor newVendor = new Vendor("Vendoro", "Pastry Store Owner");
      string result = newVendor.VendorDescription;
      Assert.AreEqual(description, result);
    }
  }
}