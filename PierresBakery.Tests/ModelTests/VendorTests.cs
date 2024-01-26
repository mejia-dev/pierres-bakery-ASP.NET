using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class VendorTests: IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new Vendor();
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      Vendor testVendor = new Vendor();
      int result = testVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsVendorInstanceList_Linst()
    {
      Vendor testVendor = new Vendor();
      Vendor testVendor2 = new Vendor();
      List<Vendor> expected = new List<Vendor> { testVendor, testVendor2 };
      CollectionAssert.AreEqual(expected, Vendor.GetAll());
    }

    [TestMethod]
    public void ClearAll_ClearsVendorInstanceList_Void()
    {
      Vendor testVendor = new Vendor();
      Vendor testVendor2 = new Vendor();
      List<Vendor> expected = new List<Vendor> {};
      CollectionAssert.AreEqual(expected, Vendor.ClearAll());
    }
  }

}