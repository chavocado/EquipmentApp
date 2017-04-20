using Microsoft.AspNet.Mvc;
using CharacterSheetApp.Models;
using System;

namespace CharacterSheetApp.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      var name = "Shield";
      return View(Models.Equipment.GetAll());
    }

    public IActionResult Create(string EquipmentName)
    {
      var model = new CharacterSheetApp.Models.Equipment();
      Models.Equipment.Create(EquipmentName);
      return RedirectToAction("Index");
    }
  }
}
