namespace VendorTracker.Models
{
	public class Order
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public string Date { get; set; }
		
		public Order(string title, string description = "", string date = "0000-00-00", double price = 0)
		{
			Title = title;
			Description = description;
			Price = price;
			Date = date;
		}
	}
}