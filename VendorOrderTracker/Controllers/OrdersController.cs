using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;


namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/vendor/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendor/{vendorId}/orders/{ordersId}")]
    public ActionResult Show(int vendorId, int ordersId)
    {
      Orders order = Orders.Find(ordersId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("orders", order);
      model.Add("vendor", vendor);
      return View(model);
    }

  }
}
