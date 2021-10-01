using System.Collections.Generic;

namespace Store
{
  public class Vendor
  {
    public string VendorName { get; set; }
    // public string VendorDescription { get; set; }

    public Vendor(string name)
    {
      VendorName = name;
      // VendorDescription = description;
    }
  }
}