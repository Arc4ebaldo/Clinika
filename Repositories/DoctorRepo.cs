using Clinica.Models;

namespace Clinica.Repositories;

public class DoctorRepo
{
    private ApplicationContext context;

    public DoctorRepo()
    {
        context = new();
    }

    public void Create(Doctor newDoctor)
    {
        context.Doctors.Add(newDoctor);
        context.SaveChanges();

    }

    public Doctor? GetById(int id)
    {
        return context.Doctors.Find(id);
    }

    public IEnumerable<Doctor>? GetAll()
    {
        return context.Doctors.AsEnumerable();
    }

    public void Update(Doctor updatedDoctor)
    {
        Doctor? doctorToUpdate = context.Doctors.Find(updatedDoctor.Id);
        doctorToUpdate.FirstName = updatedDoctor.FirstName;
        doctorToUpdate.LastName = updatedDoctor.LastName;
        doctorToUpdate.Specialization = updatedDoctor.Specialization;
        doctorToUpdate.PhoneNumber = updatedDoctor.PhoneNumber;
        doctorToUpdate.Email = updatedDoctor.Email;
        context.SaveChanges();
    }

    public void DeleteById(int id)
    {
        context.Doctors
            .Remove(context.Doctors.Find(id));
        context.SaveChanges();
    }
}