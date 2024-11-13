using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Tp3_2375637.Models
{
  public class Score
  {
    public int id { get; set; }

    [Required]
    [MaxLength(30)]
    public string Pseudo { get; set; }

    [Required]
    public string ScoreValue { get; set; }

    [Required]
    public string TimeInSeconds { get; set; }

    [Required]
    public string Date { get; set; }

    [Required]
    public bool IsPublic { get; set; }

    [JsonIgnore]
    public virtual User? User { get; set; }
    public string? UserId { get; set; }


  }
}
