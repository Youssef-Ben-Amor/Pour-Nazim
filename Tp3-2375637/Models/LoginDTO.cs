using System.ComponentModel.DataAnnotations;

namespace Tp3_2375637.Models
{
  public class LoginDTO
  {
    [Required]
    public String Username { get; set; } = null!;

    [Required]
    public String Password { get; set; } = null!;

  }
}
