using System.Collections.Generic;

namespace Store
{
  public class Order
  {
    public string OrderTitle { get; set; }
    public string OrderDescription { get; set; }
    public int OrderPrice {get; set;}
    public string OrderDate { get; set; }
    // public int Id { get; }
    // private static List<Item> _orderList = new List<Item> { };

    public Order(string title, string description, int price, string duedate)
    {
      OrderTitle = title;
      OrderDescription = description;
      OrderPrice = price;
      OrderDate = duedate;
    }
  }
}