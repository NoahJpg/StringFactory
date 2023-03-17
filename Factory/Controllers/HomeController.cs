using Factory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index() 
    {
      Engineer[] engineers = _db.Engineers.ToArray();
      Machine[] machines = _db.Machines.ToArray();
      Dictionary<string, object[]> model = new Dictionary<string, object[]>();
      model.Add("engineers", engineers);
      model.Add("machines", machines);
      return View(model);
    }
  }
}