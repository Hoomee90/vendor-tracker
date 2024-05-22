using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
	[TestClass]
	public class OrderTests : IDisposable
	{
		
		public void Dispose()
		{
			Order.ClearAll();
		}
		
		[TestMethod]
		public void OrderConstructor_CreateInstanceOfOrder_Order()
		{
			Order newOrder = new("raspberry");
			Assert.AreEqual(typeof(Order), newOrder.GetType());
		}
		
		[TestMethod]
		public void GetTitle_ReturnsTitle_String()
		{
			string title = "apple";
			Order newOrder = new(title);
			string result = newOrder.Title;
			Assert.AreEqual(title, result);
		}
		
		[TestMethod]
		public void SetTitle_SetsValueOfTitle_Void()
		{
			Order newOrder = new("cheese");
			string newTitle = "pumpkin";
			newOrder.Title = newTitle;
			Assert.AreEqual(newTitle, newOrder.Title);
		}
		
		[TestMethod]
		public void GetDescription_ReturnsDescription_String()
		{
			string description = "red";
			Order newOrder = new("apples", description);
			string result = newOrder.Description;
			Assert.AreEqual(description, result);
		}
		
		[TestMethod]
		public void SetDescription_SetsValueOfDescription_Void()
		{
			Order newOrder = new("cheese", "red");
			string newDescription = "loves you";
			newOrder.Description = newDescription;
			Assert.AreEqual(newDescription, newOrder.Description);
		}
		
		[TestMethod]
		public void GetDate_ReturnsDate_String()
		{
			string date = "2013-10-26";
			Order newOrder = new("pumpkin", "goes round and round", date);
			string result = newOrder.Date;
			Assert.AreEqual(date, result);
		}
		
		[TestMethod]
		public void SetDate_SetsValueOfDate_Void()
		{
			Order newOrder = new("melon", "when it splits, a sweet dream is created", "2013-10-26");
			string newDate = "2014-04-02";
			newOrder.Date = newDate;
			Assert.AreEqual(newDate, newOrder.Date);
		}
		
		[TestMethod]
		public void GetPrice_ReturnsPrice_Double()
		{
			double price = 5;
			Order newOrder = new("cake", "bitter", "2013-10-26", price);
			double result = newOrder.Price;
			Assert.AreEqual(price, result);
		}
		
		[TestMethod]
		public void SetPrice_SetsValueOfPrice_Void()
		{
			Order newOrder = new("cake", "the dream of a cat", "2013-10-26", 5);
			double newPrice = 6.5;
			newOrder.Price = newPrice;
			Assert.AreEqual(newPrice, newOrder.Price);
		}

		[TestMethod]
		public void GetAll_ReturnsOrders_OrderList()
		{
			Order newOrder1 = new("hotdog");
			Order newOrder2 = new("taiyaki");
			List<Order> newList = new() { newOrder1, newOrder2 };
			List<Order> result = Order.GetAll();
			CollectionAssert.AreEqual(newList, result);
		}
		
		[TestMethod]
		public void GetId_ReturnsIdAssignedOnInitialization_Int()
		{
			Order newOrder = new("rocky");
			int result = newOrder.Id;
			Assert.AreEqual(1, result);
		}
		
		[TestMethod]
		public void Find_ReturnCorrectOrder_Order()
		{
			Order newOrder1 = new("tea");
			Order newOrder2 = new("dubious purple drink");
			Order result = Order.Find(2);
			Assert.AreEqual(newOrder2, result);
		}
	}
}