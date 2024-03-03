using Clinica.DTO;
using Clinica.Models;
using Clinica.Repositories;

namespace Clinica.Services;

public class AppointmentService
{
    private AppointmentRepo appointmentRepo;

    public AppointmentService()
    {
        appointmentRepo = new();
    }

    public void CreateAppointment(AppointmentDTO newAppointment)
    {
        using (var context = new ApplicationContext())
        {
            Patient patient = context.Patients
                .Where(p => p.FirstName == newAppointment.PatientFirstName && p.LastName == newAppointment.PatientLastName)
                .First();
            Doctor doctor = context.Doctors.Where(d => d.FirstName == newAppointment.DoctorFirstName && d.LastName == newAppointment.DoctorLastName)
                .First();
            Appointment appointment = new Appointment(
                DateTime.Parse(newAppointment.DataTime),
                patient,
                doctor,
                newAppointment.Desctiprion
            );
            context.Appointments.Add(appointment);
            context.SaveChanges();
        }
    }

    public AppointmentDTO? GetAppointmentById(int id)
    {
        return ToAppointmentDTO(appointmentRepo.GetById(id));
    }

    public List<AppointmentDTO?> GetAllAppointment()
    {
        List<AppointmentDTO?> appointmentList = new();
        foreach (var appointment in appointmentRepo.GetAll())
        {
            appointmentList.Add(ToAppointmentDTO(appointment));
        }
        return appointmentList;
    }

    public void UpdateAppointment(AppointmentDTO updatedAppointment)
    {
        appointmentRepo.Update(ToAppointment(updatedAppointment));
    }

    public void DeleteAppointmentById(int id)
    {
        appointmentRepo.DeleteById(id);
    }

    private Appointment ToAppointment(AppointmentDTO appointmentDTO)
    {
        using (ApplicationContext context = new())
        {
            Patient patient = context.Patients
                .Where(p => p.FirstName == appointmentDTO.PatientFirstName && p.LastName == appointmentDTO.PatientLastName)
                .First();
            Doctor doctor = context.Doctors
                .Where(d => d.FirstName == appointmentDTO.DoctorFirstName && d.LastName == appointmentDTO.DoctorLastName)
                .First();
            return new Appointment(
                appointmentDTO.Id is null ? 0 : int.Parse(appointmentDTO.Id),
                DateTime.Parse(appointmentDTO.DataTime),
                patient,
                doctor,
                appointmentDTO.Desctiprion
            );
        }
    }

    private AppointmentDTO? ToAppointmentDTO(Appointment appointment)
    {
        DoctorRepo doctorRepo = new();
        Doctor? doctor = doctorRepo.GetById(appointment.DoctorId);
        PatienRepo patienRepo = new();
        Patient? patient = patienRepo.GetById(appointment.PatientId);
        return appointment is null ? null :
            new AppointmentDTO(
                appointment.Id.ToString(),
                appointment.DataTime.ToString(),
                patient.FirstName,
                patient.LastName,
                doctor.FirstName,
                doctor.LastName,
                appointment.Desctiprion
            );
    }
}