using Clinica.Models;

namespace Clinica.DTO;

public class AppointmentDTO
{
    public AppointmentDTO()
    {
    }

    public AppointmentDTO(
            string dateTime,
            string patientFirstName,
            string patientLastName,
            string doctorFirstName,
            string doctorLastName,
            string? desctiprion
        )
    {
        DataTime = dateTime;
        PatientFirstName = patientFirstName;
        PatientLastName = patientLastName;
        DoctorFirstName = doctorFirstName;
        DoctorLastName = doctorLastName;
        Desctiprion = desctiprion;
    }

    public AppointmentDTO(
            string? id,
            string dateTime,
            string patientFirstName,
            string patientLastName,
            string doctorFirstName,
            string doctorLastName,
            string? desctiprion
        ) : this(dateTime, patientFirstName, patientLastName, doctorFirstName, doctorLastName, desctiprion)
    {
        Id = id;
    }

    public string? Id { get; set; }
    public string DataTime { get; set; }
    public string PatientFirstName { get; set; }
    public string PatientLastName { get; set; }
    public string DoctorFirstName { get; set; }
    public string DoctorLastName { get; set; }
    public string? Desctiprion { get; set; }

    public Appointment ToAppointment()
    {
        using (ApplicationContext context = new())
        {
            if (Id is null)
            {
                return new Appointment(
                    DateTime.Parse(DataTime),
                    context.Patients
                        .Where(p => p.FirstName == PatientFirstName && p.LastName == PatientLastName)
                        .First(),
                    context.Doctors
                        .Where(d => d.FirstName == DoctorFirstName && d.LastName == DoctorLastName)
                        .First(),
                    Desctiprion
                );
            }
            return new Appointment(
                int.Parse(Id),
                DateTime.Parse(DataTime),
                context.Patients
                    .Where(p => p.FirstName == PatientFirstName && p.LastName == PatientLastName)
                    .First(),
                context.Doctors
                    .Where(d => d.FirstName == DoctorFirstName && d.LastName == DoctorLastName)
                    .First(),
                Desctiprion
            );
        }
    }
}