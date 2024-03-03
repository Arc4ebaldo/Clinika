using System.ComponentModel.DataAnnotations;

namespace Clinica.Models;

public class Appointment
{
    public Appointment()
    {
    }

    public Appointment(
        DateTime dateTime,
        Patient patient,
        Doctor doctor,
        string? desctiprion)
    {
        DataTime = dateTime;
        PatientId = patient.Id;
        Patient = patient;
        DoctorId = doctor.Id;
        Doctor = doctor;
        Desctiprion = desctiprion;
    }

    public Appointment(
        int id,
        DateTime dateTime,
        Patient patient,
        Doctor doctor,
        string? desctiprion
        ) : this(dateTime, patient, doctor, desctiprion)
    {
        Id = id;
    }

    [Key]
    public int Id { get; set; }
    public DateTime DataTime { get; set; }
    public int PatientId { get; set; }
    public Patient Patient { get; set; }
    public int DoctorId { get; set; }
    public Doctor Doctor { get; set; }
    public string? Desctiprion { get; set; }

}