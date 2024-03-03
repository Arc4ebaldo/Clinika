using System.Security.Cryptography.X509Certificates;
using Clinica.Models;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Clinica.Repositories;

public class DiseaseRepo
{
    private ApplicationContext context;

    public DiseaseRepo()
    {
        context = new();
    }

    public void Create(Disease newDisease)
    {
        context.Diseases.Add(newDisease);
        context.SaveChanges();
    }

    public Disease? GetById(int id)
    {
        return context.Diseases.Find(id);
    }

    public IEnumerable<Disease?> GetAll()
    {
        return context.Diseases.AsEnumerable();
    }
    
    public IEnumerable<Disease?>? GetAllByPatientId(int id)
    {
        return context.Diseases.Where(d => d.PatientId == id).AsEnumerable();
    }

    public void Update(Disease updatedDisease)
    {
        Disease? diseaseToUpdate = context.Diseases.Find(updatedDisease.Id);
        diseaseToUpdate.Patient = updatedDisease.Patient;
        diseaseToUpdate.Start = updatedDisease.Start;
        diseaseToUpdate.Stop = updatedDisease.Stop;
        diseaseToUpdate.Desctiprion = updatedDisease.Desctiprion;
        context.SaveChanges();
    }

    public void DeleteById(int id)
    {
        context.Diseases
            .Remove(context.Diseases.Find(id));
        context.SaveChanges();
    }
}