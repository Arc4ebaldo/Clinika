using Clinica.Models;

namespace Clinica.DTO;

public class DiseaseDTO
{
    public DiseaseDTO()
    {
    }

    public DiseaseDTO(
            string patientFirstName,
            string patientSecondName,
            string startDay,
            string? stopDay,
            string desctiprion
        )
    {
        PatientFirstName = patientFirstName;
        PatientLastName = patientSecondName;
        StartDay = startDay;
        StopDay = stopDay;
        Desctiprion = desctiprion;
    }

    public DiseaseDTO(
            string? id,
            string patientFirstName,
            string patientSecondName,
            string startDay,
            string? stopDay,
            string desctiprion
        ) : this(patientFirstName, patientSecondName, startDay, stopDay, desctiprion)
    {
        Id = id;
    }

    public string? Id { get; set; }
    public string PatientFirstName { get; set; }
    public string PatientLastName { get; set; }
    public string StartDay { get; set; }
    public string? StopDay { get; set; }
    public string Desctiprion { get; set; }
}