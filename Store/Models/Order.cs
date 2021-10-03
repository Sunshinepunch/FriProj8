using System.Collections.Generic;

namespace Store
{
  public class Order
  {
    public string OrderTitle { get; set; }
    public string OrderDescription { get; set; }
    public int OrderPrice {get; set;}
    public string OrderDate { get; set; }
    public int Id { get; }
    private static List<Order> _orderList = new List<Order> { };

    public Order(string title, string description, int price, string duedate)
    {
      OrderTitle = title;
      OrderDescription = description;
      OrderPrice = price;
      OrderDate = duedate;
      _orderList.Add(this);
      Id = _orderList.Count;
    }

     public static List<Order> GetAll()
    {
      return _orderList;
    }
    public static void ClearAll()
    {
      _orderList.Clear();
    }
    public static Order Find(int searchId)
    {
      return _orderList[searchId-1];
    }
  }
}