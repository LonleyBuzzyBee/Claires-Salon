using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
  
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int StylistId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Client> Clients{ get; set; }
  }
}