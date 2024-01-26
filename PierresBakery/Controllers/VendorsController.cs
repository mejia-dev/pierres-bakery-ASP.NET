using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;

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
      public ActionResult Create(string vendorName)
      {
        Vendor newVendor = new Vendor(vendorName);
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
    }
}