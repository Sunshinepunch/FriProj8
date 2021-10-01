using System.Collections.Generic;

namespace Store
{
  public class Vendor
  {
    public string VendorName { get; set; }
    private static List<Vendor> _vendorList = new List<Vendor> {};
    public string VendorDescription { get; set; }
    // public int Id { get; }
    // public List<Order> Orders { get; set;}

    public Vendor(string name, string description)
    {
      VendorName = name;
      _vendorList.Add(this);
      VendorDescription = description;

    }
  }
}