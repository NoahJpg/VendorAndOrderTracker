using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VenderAndOrderTracker.Models;
using System;

namespace VenderAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {

    [TestMethod]
    public void OrderConstrctor_CreatesIntanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "10 Breads";

      Order newOrder = new Order(description);
      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "10 Breads";
      Order newOrder = new Order(description);

      string updatedDescription = "20 Pastries";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      Assert.AreEqual(updatedDescription, result);
    }
  }
}