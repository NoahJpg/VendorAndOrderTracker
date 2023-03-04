using Microsoft.AspNetCore.Mvc;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Controllers
{
  public class OrderController : Controller
  {

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/Info")]
    public ActionResult Index(int vendorId, int orderId)
    {
      Vendor foundVendor = Vendor.Find(vendorId);
      Order foundOrder = Order.Find(orderId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("vendor", foundVendor);
      model.Add("order", foundOrder);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orderInfo")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, decimal orderPrice, DateTime orderDate)
    {
      Vendor vendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      vendor.AddOrder(newOrder);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", vendor.Orders);
      model.Add("vendor", vendor);
      return View("Show", model);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }
  }
}