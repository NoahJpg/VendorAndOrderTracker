using Microsoft.VisualStudio.TestTools.UnitTesting;
using VenderAndOrderTracker.Models;
using System;
using System.Collections.Generic;

namespace VenderAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests :IDisposable
  {
    [TestMethod]
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstancesOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name);

      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name);

      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    
  }
}