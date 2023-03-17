using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "The Engineer must have a name!")]
    public string EngineerName { get; set; }
    [Required(ErrorMessage = "The Engineer must have details!")]
    public string EngineerDetails { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}