using Microsoft.AspNetCore.Mvc;
using SpendMemo.Models;

namespace SpendMemo.Controllers
{
  public class ItemController : Controller
  {
    public IActionResult Overview()
    {
      var item = new Item() { Name = "Keyboard" };
      return View(item);
    }

    public IActionResult Edit(int id)
    {
      return Content("id = " + id);
    }
  }
}