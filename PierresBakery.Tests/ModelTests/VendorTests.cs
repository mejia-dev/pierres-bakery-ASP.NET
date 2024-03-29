using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new Vendor("VendorCo.", "Is a vendor. Can vend.");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      Vendor testVendor = new Vendor("VendorCo.", "Is a vendor. Can vend.");
      int result = testVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsVendorInstanceList_List()
    {
      Vendor testVendor = new Vendor("VendorCo.", "Is a vendor. Can vend.");
      Vendor testVendor2 = new Vendor("VendorCo.", "Is a vendor. Can vend.");
      List<Vendor> expected = new List<Vendor> { testVendor, testVendor2 };
      CollectionAssert.AreEqual(expected, Vendor.GetAll());
    }

    [TestMethod]
    public void ClearAll_ClearsVendorInstanceList_Void()
    {
      Vendor testVendor = new Vendor("VendorCo.", "Is a vendor. Can vend.");
      Vendor testVendor2 = new Vendor("VendorCo.", "Is a vendor. Can vend.");
      Vendor.ClearAll();
      List<Vendor> expected = new List<Vendor> { };
      CollectionAssert.AreEqual(expected, Vendor.GetAll());
    }

    [TestMethod]
    public void Find_ReturnsVendorFromInstanceList_Vendor()
    {
      Vendor testVendor = new Vendor("VendorCo.", "Is a vendor. Can vend.");
      Vendor testVendor2 = new Vendor("VendorCo.", "Is a vendor. Can vend.");
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(testVendor2, result);
    }

    [TestMethod]
    public void GetOrders_ReturnsOrderInstancesAssociatedWithVendor_List()
    {
      Vendor testVendor = new Vendor("VendorCo.", "Is a vendor. Can vend.");
      List<Order> expected = new List<Order> { };
      CollectionAssert.AreEqual(expected, testVendor.Orders);
    }

    [TestMethod]
    public void GetName_ReturnsOrderInstanceName_String()
    {
      string vendorName = "VendorCo.";
      Vendor testVendor = new Vendor(vendorName, "Is a vendor. Can vend.");
      Assert.AreEqual(vendorName, testVendor.Name);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderInstanceWithVendorInstance_Void()
    {
      Vendor testVendor = new Vendor("VendorCo.", "Is a vendor. Can vend.");
      Order testOrder = new Order("Widget Order", "Is a widget.", 1);
      testVendor.AddOrder(testOrder);
      List<Order> expected = new List<Order> { testOrder };
      CollectionAssert.AreEqual(expected, testVendor.Orders);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescriptionOfVendorInstance_String()
    {
      string desc = "Is a vendor. Can vend.";
      Vendor testVendor = new Vendor("VendorCo.", desc);
      Assert.AreEqual(desc, testVendor.Description);
    }

  }

}