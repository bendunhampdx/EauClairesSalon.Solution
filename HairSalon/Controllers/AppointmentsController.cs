using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Linq;

namespace HairSalon.Controllers
{
  public class AppointmentsController : Controller
  {
    private readonly HairSalonContext _db;

    public AppointmentsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Create(int id)
    {
      ViewBag.Client = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      return View();
    }

    [HttpPost]
    public ActionResult Create(Appointment appointment)
    {
      _db.Appointments.Add(appointment);
      _db.SaveChanges();
      return RedirectToAction("Details", "Clients", new { id = appointment.ClientId });
    }

    public ActionResult Edit(int id)
    {
      var thisAppointment = _db.Appointments.FirstOrDefault(appointment => appointment.AppointmentId == id);
      ViewBag.ClientId = new SelectList(_db.Clients, "ClientId", "Name");
      return View(thisAppointment);
    }

    [HttpPost]
    public ActionResult Edit(Appointment appointment)
    {
      _db.Entry(appointment).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", "Clients", new { id = appointment.ClientId });
    }

    public ActionResult Delete(int id)
    {
      var thisAppointment = _db.Appointments.FirstOrDefault(appointment => appointment.AppointmentId == id);
      return View(thisAppointment);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int Id)
    {
      var thisAppointment = _db.Appointments.FirstOrDefault(appointment => appointment.AppointmentId == Id);
      _db.Appointments.Remove(thisAppointment);
      _db.SaveChanges();
      return RedirectToAction("Details", "Clients", new { id = Id });
    }
  }
}