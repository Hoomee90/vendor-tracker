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
	}
}