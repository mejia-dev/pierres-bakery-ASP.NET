using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;
using System.Collections.Generic;

namespace PierresBakery.Controllers
{
    public class VendorsController : Controller
    {

      [HttpGet("/vendors")]
      public ActionResult Index()
      {
        List<Vendor> model = Vendor.GetAll();
        return View(model);
      }

      [HttpGet("/vendors/new")]
      public ActionResult New()
      {
        return View();
      }

      [HttpPost("/vendors")]
      public ActionResult Create(string vendorName, string vendorDescription)
      {
        Vendor newVendor = new Vendor(vendorName,vendorDescription);
        return RedirectToAction("Index");
      }

      [HttpGet("/vendors/{id}")]
      public ActionResult Show(int id)
      {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Vendor currentVendor = Vendor.Find(id);
        List<Order> orders = currentVendor.Orders;
        model.Add("vendor", currentVendor);
        model.Add("orders", orders);
        return View(model);
      }

      [HttpPost("/vendors/{id}/orders")]
      public ActionResult Create(int id, string orderTitle, string orderDescription, int orderPrice)
      {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Vendor currentVendor = Vendor.Find(id);
        Order newOrder = new Order(orderTitle, orderDescription, orderPrice);
        currentVendor.AddOrder(newOrder);
        List<Order> orders = currentVendor.Orders;
        model.Add("vendor", currentVendor);
        model.Add("orders", orders);
        return View("Show", model);
      }
    }
}