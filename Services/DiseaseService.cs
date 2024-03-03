using Clinica.DTO;
using Clinica.Models;
using Clinica.Repositories;

namespace Clinica.Services;

public class DiseaseService
{
    private DiseaseRepo diseaseRepo;

    public DiseaseService()
    {
        diseaseRepo = new();
    }

    public void CreateDisease(DiseaseDTO newDisease)
    {
        using (var context = new ApplicationContext())
        {
            Patient patient = context.Patients
                .Where(p => p.FirstName == newDisease.PatientFirstName && p.LastName == newDisease.PatientLastName)
                .First();
            Disease disease = new Disease(
                patient,
                DateOnly.Parse(newDisease.StartDay),
                DateOnly.Parse(newDisease.StopDay),
                newDisease.Desctiprion
            );
            context.Diseases.Add(disease);
            context.SaveChanges();
        }
    }

    public DiseaseDTO? GetDiseaseById(int id)
    {
        return ToDiseaseDTO(diseaseRepo.GetById(id));
    }

    public List<DiseaseDTO?> GetAllDiseases()
    {
        List<DiseaseDTO?> diseaseList = new();
        foreach (var disease in diseaseRepo.GetAll())
        {
            diseaseList.Add(ToDiseaseDTO(disease));
        }
        return diseaseList;
    }

    public void UpdateDisease(DiseaseDTO updatedDisease)
    {
        diseaseRepo.Update(ToDisease(updatedDisease));
    }

    public void DeleteDiseaseById(int id)
    {
        diseaseRepo.DeleteById(id);
    }


    private Disease ToDisease(DiseaseDTO diseaseDTO)
    {
        using (ApplicationContext context = new())
        {
            Patient patient = context.Patients
                .Where(p => p.FirstName == diseaseDTO.PatientFirstName && p.LastName == diseaseDTO.PatientLastName)
                .First();

            return new Disease(
                diseaseDTO.Id is null ? 0 : int.Parse(diseaseDTO.Id),
                patient,
                DateOnly.Parse(diseaseDTO.StartDay),
                DateOnly.Parse(diseaseDTO.StopDay),
                diseaseDTO.Desctiprion
            );
        }
    }

    private DiseaseDTO? ToDiseaseDTO(Disease? disease)
    {
        PatienRepo patienRepo = new();
        Patient? patient = patienRepo.GetById(disease.PatientId);
        return disease is null ? null :
            new DiseaseDTO(
                disease.Id.ToString(),
                patient.FirstName,
                patient.LastName,
                disease.Start.ToString(),
                disease.Stop.ToString(),
                disease.Desctiprion
        );
    }
}