using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }   

    [Route("/")]
    public ActionResult Display() {
      DisplayVariable myDisplayVariable = new DisplayVariable();
      myDisplayVariable.DayOfWeek = "Friday";
      myDisplayVariable.Adjective1 = "funny";
      return View(myDisplayVariable); } 

      [Route("/form")]
      public ActionResult Form() { return View(); }

      [Route("/story")]
      public ActionResult Story(string dayOfWeek, string adjective1)
      {
        DisplayVariable myDisplayVariable = new DisplayVariable();
        myDisplayVariable.DayOfWeek = dayOfWeek;
        myDisplayVariable.Adjective1 = adjective1;
        return View(myDisplayVariable);
      }
  }
}

