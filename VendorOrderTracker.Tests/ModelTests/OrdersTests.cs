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

      Assert.AreEqual(price, priceResult);
    }


    // [TestMethod]
    // public void GetAll_ReturnsItems_ItemList()
    // {
    //   //Arrange
    //   string description01 = "Walk the dog";
    //   string description02 = "Wash the dishes";
    //   Item newItem1 = new Item(description01);
    //   Item newItem2 = new Item(description02);
    //   List<Item> newList = new List<Item> { newItem1, newItem2 };

    //   //Act
    //   List<Item> result = Item.GetAll();

    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }

  }
  
}