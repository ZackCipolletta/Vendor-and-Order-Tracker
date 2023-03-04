using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test Vendor", "test Description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      // Arrange
      string name = "test Name";
      string description = "dest Description";
      Vendor newVendor = new Vendor(name, description);

      //Act
      string testName = newVendor.Name;

      // Assert
      Assert.AreEqual(name, testName);
    }

    [TestMethod]
    public void GetVendorDescription_ReturnsVendorDescription_String()
    {
      // Arrange
      string name = "test Name";
      string description = "test Description";
      Vendor newVendor = new Vendor(name, description);

      // Act
      string testDescription = newVendor.Description;

      // Assert
      Assert.AreEqual(description, testDescription);
    }

    [TestMethod]
    public void GetAll_ReturnsAllInstancesOfVendorObject_VendorList()
    {
      // Arrange
      string name1 = "first Name";
      string description1 = "first Description";
      string name2 = "second Name";
      string description2 = "second Description";

      // Act
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);
      List<Vendor> testList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> resultList = Vendor.GetAll();

      // Assert
      CollectionAssert.AreEqual(testList, resultList);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      // Arrange
      string name1 = "first Name";
      string description1 = "first Description";
      string name2 = "second Name";
      string description2 = "second Description";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);

      // Act
      int idResult = newVendor1.Id;

      //Assert
      Assert.AreEqual(1, idResult);
    }

    [TestMethod]
    public void AddOrder_AssociatesAnOrdersObjectWithSpecificVendorObject_ItemList()
    {

      //Arrange
      string orderTitle = "test Title";
      string orderDescription = "test Description";
      int orderPrice = 99;
      DateOnly orderDate = new DateOnly(2025, 1, 1);
      Orders newOrder = new Orders(orderTitle, orderDescription, orderPrice, orderDate);
      List<Orders> newOrdersList = new List<Orders> { newOrder };

      string vendorName = "test Name";
      string vendorDescription = "test Description";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      newVendor.AddOrder(newOrder);

      // Act
      List<Orders> result = newVendor.Orders;

      // Assert
      CollectionAssert.AreEqual(newOrdersList, result);
    }

  }
}