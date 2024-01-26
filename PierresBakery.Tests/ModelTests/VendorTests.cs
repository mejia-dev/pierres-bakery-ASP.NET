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
    public void GetAll_ReturnsVendorInstanceList_List()
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
      Vendor.ClearAll();
      List<Vendor> expected = new List<Vendor> {};
      CollectionAssert.AreEqual(expected, Vendor.GetAll());
    }

    [TestMethod]
    public void Find_ReturnsVendorFromInstanceList_Vendor()
    {
      Vendor testVendor = new Vendor();
      Vendor testVendor2 = new Vendor();
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(testVendor2, result);
    }

    [TestMethod]
    public void GetOrders_ReturnsOrderInstancesAssociatedWithVendor_List()
    {
      Vendor testVendor = new Vendor();
      List<Order> expected = new List<Order> {};
      CollectionAssert.AreEqual(expected,testVendor.Orders);
    }
  }

}