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
        diseaseRepo.Create(ToDisease(newDisease));
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
        PatienRepo patienRepo = new();
        return new Disease(
            int.Parse(diseaseDTO.Id),
            patienRepo.GetByFirstnameAndLastname(diseaseDTO.PatientFirstName, diseaseDTO.PatientLastName),
            DateOnly.Parse(diseaseDTO.StartDay),
            DateOnly.Parse(diseaseDTO.StopDay),
            diseaseDTO.Desctiprion
        );
    }

    private DiseaseDTO? ToDiseaseDTO(Disease? disease)
    {
        return disease is null ? null :
            new DiseaseDTO(
                disease.Id.ToString(),
                disease.Patient.FirstName,
                disease.Patient.LastName,
                disease.Start.ToString(),
                disease.Stop.ToString(),
                disease.Desctiprion
        );
    }
}