using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace Tp3_2375637.Models
{
  public class User :IdentityUser
  {
    [JsonIgnore]
    public virtual List<Score> Scores { get; set; } = null!;
  }
}
