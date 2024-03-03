using System.ComponentModel.DataAnnotations;

namespace Clinica.Models;

public class Disease
{
    public Disease()
    {
    }

    public Disease(Patient patient, DateOnly start, DateOnly? stop, string? desctiprion)
    {
        Patient = patient;
        Start = start;
        Stop = stop;
        Desctiprion = desctiprion;
    }

    public Disease(
        int id,
        Patient patient,
        DateOnly start,
        DateOnly? stop,
        string? desctiprion
        ) : this(patient, start, stop, desctiprion)
    {
        Id = id;

    }

    [Key]
    public int Id { get; set; }
    public int PatientId { get; set; }
    public Patient Patient { get; set; }
    public DateOnly Start { get; set; }
    public DateOnly? Stop { get; set; }
    public string? Desctiprion { get; set; }
}