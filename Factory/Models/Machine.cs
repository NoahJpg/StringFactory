using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "The Machine must have a name!")]
    public string MachineName { get; set; }
    [Required(ErrorMessage = "You Machine must have details!")]
    public string MachineDetails { get; set; }
    public List<EngineerMachine> JoinEntities { get;}
  }
}