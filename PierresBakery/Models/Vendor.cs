using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Vendor
  {
    public int Id { get; }
    private static List<Vendor> _instances = new List<Vendor> {};
    public Vendor()
    {
      _instances.Add(this);
      Id = _instances.Count;
    }
  }
}