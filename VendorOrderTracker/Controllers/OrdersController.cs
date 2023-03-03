using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/artists/{artistsId}/albums/new")] 
    public ActionResult New()
    {
      return View();
    }


  }
}
