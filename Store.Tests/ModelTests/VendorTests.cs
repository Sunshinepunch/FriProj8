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
    Vendor newVendor = new Vendor("test");
    Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void VendorConstructor_CreatesVendorWithName_Vendoro()
    {
      string name = "Vendoro";
      Vendor newVendor = new Vendor("Vendoro");
      string result = newVendor.VendorName;
      Assert.AreEqual(name, result);
    }
  }
}