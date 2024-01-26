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
      Order testOrder = new Order("Widget Order");
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_GetsTitleOfOrderInstance_String()
    {
      string title = "Widget Order";
      Order testOrder = new Order(title);
      Assert.AreEqual(title,testOrder.Title);
    }
  }
}