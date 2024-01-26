using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> { };
    public string Title { get; }
    public string Description { get; }

    public Order(string title, string description)
    {
      _instances.Add(this);
      Title = title;
      Description = description;
    }
  }
}