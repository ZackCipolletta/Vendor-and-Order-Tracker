using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Orders.ClearAll();
    }

    [TestMethod]
    public void OrdersConstructor_CreatesInstanceOfOrder_Orders()
    {
      Orders newOrder = new Orders("test Title", "test Description", 99, new DateTime(2025, 1, 1));
      Assert.AreEqual(typeof(Orders), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      //Arrange
      string title = "test Title";
      string description = "test Description";
      int price = 99;
      DateTime date = new DateTime(2025, 1, 1);

      //Act
      Orders newOrder = new Orders(title, description, price, date);
      string titleResult = newOrder.Title;

      // Assert
      Assert.AreEqual(title, titleResult);
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      //Arrange
      string title = "test Title";
      string description = "test Description";
      int price = 99;
      DateTime date = new DateTime(2025, 1, 1);

      //Act
      Orders newOrder = new Orders(title, description, price, date);
      string descriptionResult = newOrder.Description;

      // Assert
      Assert.AreEqual(description, descriptionResult);
    }

    [TestMethod]
    public void GetOrderPrice_ReturnsOrderPrice_String()
    {
      //Arrange
      string title = "test Title";
      string description = "test Description";
      int price = 99;
      DateTime date = new DateTime(2025, 1, 1);

      //Act
      Orders newOrder = new Orders(title, description, price, date);
      int priceResult = newOrder.Price;

      // Assert
      Assert.AreEqual(price, priceResult);
    }


    [TestMethod]
    public void GetOrderDate_ReturnsOrderDate_DateTime()
    {
      //Arrange
      string title = "test Title";
      string description = "test Description";
      int price = 99;
      DateTime date = new DateTime(2025, 1, 1);

      //Act
      Orders newOrder = new Orders(title, description, price, date);
      DateTime dateResult = newOrder.Date;

      // Assert
      Assert.AreEqual(date, dateResult);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string title = "test Title";
      string description = "test Description";
      int price = 99;
      DateTime date = new DateTime(2025, 1, 1);

      //Act
      Orders newOrder1 = new Orders(title, description, price, date);
      Orders newOrder2 = new Orders(title, description, price, date);
      int idResult = newOrder2.Id;

      // Assert
      Assert.AreEqual(2, idResult);
    }


    [TestMethod]
    public void GetAll_ReturnsOrders_OrdersList()
    {
      //Arrange
      string title1 = "test1 Title";
      string description1 = "test1 Description";
      int price1 = 99;
      DateTime date1 = new DateTime(2025, 1, 1);
      string title2 = "test2 Title";
      string description2 = "test2 Description";
      int price2 = 101;
      DateTime date2 = new DateTime(2025, 1, 2);

      Orders newOrder1 = new Orders(title1, description1, price1, date1);
      Orders newOrder2 = new Orders(title2, description2, price2, date2);
      List<Orders> newOrdersList = new List<Orders> { newOrder1, newOrder2 };

      //Act
      List<Orders> result = Orders.GetAll();

      //Assert
      CollectionAssert.AreEqual(newOrdersList, result);
    }

  }

}