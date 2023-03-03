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

      //Act
      Vendor newVendor = new Vendor(name, description);
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

      // Act
      Vendor newVendor = new Vendor(name, description);
      string testDescription = newVendor.Description;

      // Assert
      Assert.AreEqual(description, testDescription);
    }

    [TestMethod]
    public void GetAll_ReturnsAllInstancesOfVendor_VendorList()
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

      // Act
      Vendor newVendor1 = new Vendor(name1, description1);
      int idResult = newVendor1.Id;

      //Assert
      Assert.AreEqual(1, idResult);
    }

  }
}