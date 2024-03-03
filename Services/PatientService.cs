using Clinica.DTO;
using Clinica.Models;
using Clinica.Repositories;

namespace Clinica.Services;

public class PatientService
{
    private PatienRepo patientRepo;
    public PatientService() {
        patientRepo = new();
    }

    public void CreatePatient(PatientDTO newPatient) {
        patientRepo.Create(new Patient(
            newPatient.FirstName,
            newPatient.LastName,
            DateOnly.Parse(newPatient.BirthDay),
            newPatient.Adress,
            newPatient.PhoneNumber,
            null
        ));
    }

    public PatientDTO? GetPatientById(int id) {
        return ToPatientDTO(patientRepo.GetById(id));
    }

    public List<PatientDTO?> GetAllPatients() {
        List<PatientDTO?> patientList = new();
        foreach (var patient in patientRepo.GetAll())
        {
            patientList.Add(ToPatientDTO(patient));
        }
        return patientList;
    }

    public void UpdatePatient(PatientDTO updatedPation) {
        patientRepo.Update(ToPatient(updatedPation));
    }

    public void DeletePatientById(int id) {
        patientRepo.DeleteById(id);
    }

    private Patient ToPatient(PatientDTO patientDTO) {
        DiseaseRepo diseaseRepo = new();
        return new Patient(
            int.Parse(patientDTO.Id),
            patientDTO.FirstName,
            patientDTO.LastName,
            DateOnly.Parse(patientDTO.BirthDay),
            patientDTO.Adress,
            patientDTO.PhoneNumber,
            diseaseRepo.GetAllByPatientId(int.Parse(patientDTO.Id))
        );
    }

    private PatientDTO? ToPatientDTO(Patient? patient) {
        DiseaseRepo diseaseRepo = new();
        List<string?>? diseasesList = new();
        foreach (var disease in diseaseRepo.GetAllByPatientId(patient.Id))
        {
            diseasesList.Add(disease.Desctiprion);
        }
        return patient is null ? null : new PatientDTO(
            patient.Id.ToString(),
            patient.FirstName,
            patient.LastName,
            patient.BirthDay.ToString(),
            patient.Adress,
            patient.PhoneNumber,
            diseasesList
        );
    }
}