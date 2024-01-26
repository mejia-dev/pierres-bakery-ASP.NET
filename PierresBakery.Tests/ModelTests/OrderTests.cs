using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class GetOrders_ReturnsOrderInstancesAssociatedWithVendor_List
  {
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
  }
}