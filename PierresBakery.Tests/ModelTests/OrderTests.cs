using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class GetOrders_ReturnsOrderInstancesAssociatedWithVendor_List : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order testOrder = new Order("Widget Order", "Is a widget.", 1);
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_GetsTitleOfOrderInstance_String()
    {
      string title = "Widget Order";
      Order testOrder = new Order(title, "Is a widget.", 1);
      Assert.AreEqual(title, testOrder.Title);
    }

    [TestMethod]
    public void GetDescription_GetsDescriptionOfOrderInstance_String()
    {
      string desc = "Is a widget.";
      Order testOrder = new Order("Widget Order", desc, 1);
      Assert.AreEqual(desc, testOrder.Description);
    }

    [TestMethod]
    public void GetPrice_GetsPriceOfOrderInstance_Int()
    {
      int price = 1;
      Order testOrder = new Order("Widget Order", "Is a widget.", price);
      Assert.AreEqual(price, testOrder.Price);
    }

    [TestMethod]
    public void GetDate_GetsDateOfOrderInstance_DateTime()
    {
      DateTime testDateTime = DateTime.Today;
      Order testOrder = new Order("Widget Order", "Is a widget.", 1);
      Assert.AreEqual(testDateTime, testOrder.Date);
    }

    [TestMethod]
    public void GetAll_ReturnsOrderInstanceList_List()
    {
      Order testOrder = new Order("Widget Order", "Is a widget.", 1);
      Order testOrder2 = new Order("Widget Order", "Is a widget.", 1);
      List<Order> expected = new List<Order> { testOrder, testOrder2 };
      CollectionAssert.AreEqual(expected, Order.GetAll());
    }

    [TestMethod]
    public void ClearAll_ClearsOrderInstanceList_Void()
    {
      Order testOrder = new Order("Widget Order", "Is a widget.", 1);
      Order testOrder2 = new Order("Widget Order", "Is a widget.", 1);
      Order.ClearAll();
      List<Order> expected = new List<Order> { };
      CollectionAssert.AreEqual(expected, Order.GetAll());
    }

    [TestMethod]
    public void GetId_ReturnsOrderInstanceId_Int()
    {
      Order testOrder = new Order("Widget Order", "Is a widget.", 1);
      Order testOrder2 = new Order("Widget Order", "Is a widget.", 1);
      Assert.AreEqual(2, testOrder2.Id);
    }

    [TestMethod]
    public void Find_ReturnsOrderFromInstanceList_Order()
    {
      Order testOrder = new Order("Widget Order", "Is a widget.", 1);
      Order testOrder2 = new Order("Widget Order", "Is a widget.", 1);
      Order result = Order.Find(2);
      Assert.AreEqual(testOrder2, result);
    }
  }
}