using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> { };

    public Order()
    {
      _instances.Add(this);
    }
  }
}