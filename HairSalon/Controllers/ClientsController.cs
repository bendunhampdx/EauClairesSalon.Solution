using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
    public class HairSalonController : Controller
    {
      private readonly HairSalonContext _db;
      
      public RestaurantsController(HairSalonContext db)
      {
        _db = db;
      }

      public ActionResult Index()
      {
        List<Client> model = _db.Clients.Include(client => client.Stylist).ToList();
        return View(model);
      }
    }
}