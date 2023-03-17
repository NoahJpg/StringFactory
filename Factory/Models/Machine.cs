using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "The Machine name field can't be empty!")]
    public string MachineName { get; set; }
    [Required(ErrorMessage = "You must add an engineer to a machine. Have you added a machine yet?")]
    public string MachineDetails { get; set; }
    public List<EngineerMachine> JoinEntities { get;}
  }
}