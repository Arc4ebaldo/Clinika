using Clinica.Models;

namespace Clinica.Repositories;
public class AppointmentRepo
{
    private ApplicationContext context;

    public AppointmentRepo() {
        context = new();
    }

    public void Create(Appointment newAppointment) {
        context.Appointments.Add(newAppointment);
        context.SaveChanges();
    }

    public Appointment? GetById(int id){
        return context.Appointments.Find(id);
    }

    public IEnumerable<Appointment>? GetAll() {
        return context.Appointments.AsEnumerable();
    }

    public void Update(Appointment updatedAppointment) {
        Appointment? appointmentToUpdate = context.Appointments.Find(updatedAppointment.Id);
        appointmentToUpdate.Patient = updatedAppointment.Patient;
        appointmentToUpdate.Doctor = updatedAppointment.Doctor;
        appointmentToUpdate.Desctiprion = updatedAppointment.Desctiprion;
        context.SaveChanges();
    }

    public void DeleteById(int id) {
        context.Appointments
            .Remove(context.Appointments.Find(id));
    }
}