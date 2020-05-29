using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
    public int ClientId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Client> Clients{ get; set; }
  }
}