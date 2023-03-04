using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Orders
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public DateOnly Date { get; set; }
    public int Id { get; }
    private static List<Orders> _instances = new List<Orders> { };

    public Orders(string orderTitle, string orderDescription, int orderPrice, DateOnly orderDate )
    {
      Title = orderTitle;
      Description = orderDescription;
      Price = orderPrice;
      Date = orderDate;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Orders> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Orders Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}