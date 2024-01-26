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
        return View();
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

      [HttpPost("/vendors/{id}/items")]
      public ActionResult Create(int id, string itemTitle, string itemDescription, int itemPrice)
      {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Vendor currentVendor = Vendor.Find(id);
        Order newOrder = new Order(itemTitle, itemDescription, itemPrice);
        currentVendor.AddOrder(newOrder);
        List<Order> orders = currentVendor.Orders;
        model.Add("vendor", currentVendor);
        model.Add("orders", orders);
        return View("Show", model);
      }
    }
}