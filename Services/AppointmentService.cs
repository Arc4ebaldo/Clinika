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
        appointmentRepo.Create(ToAppointment(newAppointment));
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
        return new Appointment(
            appointmentDTO.Id is null ? 0 : int.Parse(appointmentDTO.Id),
            DateTime.Parse(appointmentDTO.DataTime),
            null,
            null,
            appointmentDTO.Desctiprion
        );
    }

    private AppointmentDTO? ToAppointmentDTO(Appointment appointment)
    {
        return appointment is null ? null :
            new AppointmentDTO(
                appointment.Id.ToString(),
                appointment.DataTime.ToString(),
                appointment.Patient.FirstName,
                appointment.Patient.LastName,
                appointment.Doctor.FirstName,
                appointment.Doctor.LastName,
                appointment.Desctiprion
            );
    }
}