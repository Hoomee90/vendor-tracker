using System.Collections.Generic;

namespace VendorTracker.Models
{
	public class Order
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string Date { get; set; }
		public double Price { get; set; }
		public int Id { get; }
		private static List<Order> _instances = new();
		
		public Order(string title, string description = "", string date = "0000-00-00", double price = 0)
		{
			Title = title;
			Description = description;
			Price = price;
			Date = date;
			_instances.Add(this);
			Id = _instances.Count;
		}
		
		public static List<Order> GetAll()
		{
			return _instances;
		}
		
		public static void ClearAll()
		{
			_instances.Clear();
		}
		
		public static Order Find(int id)
		{
			return _instances[id-1];
		}
	}
}