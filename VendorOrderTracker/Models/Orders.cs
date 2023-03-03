using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Orders
  {
    public string OrderTitle { get; set; }
    public string OrderDescription { get; set; }
    public int OrderPrice { get; set; }
    // public DateTime OrderDate { get; set; }
    public int Id { get; }
    private static List<Orders> _instances = new List<Orders> { };
// , DateTime orderDate
    public Orders(string orderTitle, string orderDescription, int orderPrice)
    {
      OrderTitle = orderTitle;
      OrderDescription = orderDescription;
      OrderPrice = orderPrice;
      // OrderDate = orderDate;
      _instances.Add(this);
      Id = _instances.Count;
    }

    // public static List<Orders> GetAll()
    // {
    //   return _instances;
    // }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    // public static Orders Find(int searchId)
    // {
    //   return _instances[searchId - 1];
    // }
  }
}