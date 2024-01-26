using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> { };
    public string Title { get; }
    public string Description { get; }
    public int Price { get; }
    public DateTime Date { get; }
    public int Id { get; }

    public Order(string title, string description, int price)
    {
      _instances.Add(this);
      Title = title;
      Description = description;
      Price = price;
      Date = DateTime.Today;
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}