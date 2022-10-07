using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Stylists = new HashSet<Stylist>();
    }

    public int StylistId { get; set; }
    public string Speciality { get; set; }
    public virtual ICollection<Restaurant> Stylists { get; set; }
  }
}