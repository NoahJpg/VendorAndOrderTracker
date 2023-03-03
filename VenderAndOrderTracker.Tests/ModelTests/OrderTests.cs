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
  }
}