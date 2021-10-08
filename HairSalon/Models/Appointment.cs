namespace HairSalon.Models
{
  public class Appointment
  {
    public int AppointmentId { get; set; }
    public string Text { get; set; }
    public int ClientId { get; set; }
    public virtual Client Client { get; set; }
  }
}