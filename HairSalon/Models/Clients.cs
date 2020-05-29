using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    public string Name { get; set; }
    public string HairStyle { get; set; }
    public string StyleTouchup { get; set; }
    public int CostOfTouchup { get; set; }
    public int ClientId { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist {get;set;}
  }
}