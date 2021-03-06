using System.Collections.Generic;

namespace Store
{
  public class Vendor
  {
    public string VendorName { get; set; }
    private static List<Vendor> _vendorList = new List<Vendor> {};
    public string VendorDescription { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set;}

    public Vendor(string name, string description)
    {
      VendorName = name;
      VendorDescription = description;
      _vendorList.Add(this);
      Id = _vendorList.Count;
      Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _vendorList.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _vendorList;
    }

    public static Vendor Find(int searchId)
    {
      return _vendorList[searchId-1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}