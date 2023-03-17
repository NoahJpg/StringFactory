using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "The Engineer must have a name!!")]
    public string Name { get; set; }
    public string Details { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}