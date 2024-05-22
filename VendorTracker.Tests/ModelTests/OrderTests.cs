using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
	[TestClass]
	public class OrderTests
	{
		[TestMethod]
		public void OrderConstructor_CreateInstanceOfOrder_Order()
		{
			Order newOrder = new("raspberries");
			Assert.AreEqual(typeof(Order), newOrder.GetType());
		}
		
		[TestMethod]
		public void GetTitle_ReturnsTitle_String()
		{
			string title = "apples";
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
	}
}