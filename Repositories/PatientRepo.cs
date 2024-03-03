using Clinica.Models;
using Microsoft.EntityFrameworkCore;

namespace Clinica.Repositories;

public class PatienRepo
{
    private ApplicationContext context;

    public PatienRepo()
    {
        context = new();
    }

    public void Create(Patient newPatient)
    {
        context.Patients.Add(newPatient);
        context.SaveChanges();
    }

    public Patient? GetById(int id)
    {
        return context.Patients.Find(id);
    }

    public IEnumerable<Patient>? GetAll()
    {
        return context.Patients.AsEnumerable();
    }

    public void Update(Patient updatedPatient)
    {
        Patient? patientToUpdate = context.Patients.Find(updatedPatient.Id);
        patientToUpdate.FirstName = updatedPatient.FirstName;
        patientToUpdate.LastName = updatedPatient.LastName;
        patientToUpdate.BirthDay = updatedPatient.BirthDay;
        patientToUpdate.Adress = updatedPatient.Adress;
        patientToUpdate.PhoneNumber = updatedPatient.PhoneNumber;
        patientToUpdate.Diseases = updatedPatient.Diseases;
    }

    public void DeleteById(int id)
    {
        context.Patients
            .Remove(context.Patients.Find(id));
        context.SaveChanges();
    }
}