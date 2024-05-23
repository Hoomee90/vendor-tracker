using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
	[TestClass]
	public class VendorTests : IDisposable
	{
		
		public void Dispose()
		{
			Vendor.ClearAll();
		}
		
		[TestMethod]
		public void VendorConstructor_CreateInstanceOfVendor_Vendor()
		{
			Vendor newVendor = new("Betty Crocker");
			Assert.AreEqual(typeof(Vendor), newVendor.GetType());
		}
		
		[TestMethod]
		public void GetName_ReturnsName_String()
		{
			string name = "Cabinet";
			Vendor newVendor = new(name);
			string result = newVendor.Name;
			Assert.AreEqual(name, result);
		}
		
		[TestMethod]
		public void SetName_SetsValueOfName_Void()
		{
			Vendor newVendor = new("Arcade");
			string newName = "Dream";
			newVendor.Name = newName;
			Assert.AreEqual(newName, newVendor.Name);
		}
		
		[TestMethod]
		public void GetDescription_ReturnsDescription_String()
		{
			string description = "The dream of a young goat";
			Vendor newVendor = new("Cabinet", description);
			string result = newVendor.Description;
			Assert.AreEqual(description, result);
		}
		
		[TestMethod]
		public void SetDescription_SetsValueOfDescription_Void()
		{
			Vendor newVendor = new("Betty Crocker", "Baking empire");
			string newDescription = "Global conquerors";
			newVendor.Description = newDescription;
			Assert.AreEqual(newDescription, newVendor.Description);
		}
		
		[TestMethod]
		public void GetAll_ReturnsVendors_VendorList()
		{
			Vendor newVendor1 = new("Reverie");
			Vendor newVendor2 = new("Cosmic Ice");
			List<Vendor> newList = new() { newVendor1, newVendor2 };
			List<Vendor> result = Vendor.GetAll();
			CollectionAssert.AreEqual(newList, result);
		}
		
		[TestMethod]
		public void GetId_ReturnsIdAssignedOnInitialization_Int()
		{
			Vendor newVendor = new("Nutcracker");
			int result = newVendor.Id;
			Assert.AreEqual(1, result);
		}
		
		[TestMethod]
		public void Find_ReturnCorrectVendor_Vendor()
		{
			Vendor newVendor1 = new("Spider Lily");
			Vendor newVendor2 = new("Love", "Being alone suits her well");
			Vendor result = Vendor.Find(2);
			Assert.AreEqual(newVendor2, result);
		}
	}
}