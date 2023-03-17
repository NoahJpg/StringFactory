using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required]
    public string EngineerName { get; set; }
    [Required]
    public string EngineerDetails { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}