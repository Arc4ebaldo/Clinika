using Clinica.DTO;
using Clinica.Models;
using Clinica.Repositories;

namespace Clinica.Services;
public class DoctorService
{
    private DoctorRepo doctorRepo;

    public DoctorService()
    {
        doctorRepo = new();
    }

    public void CreateDoctor(DoctorDTO newDoctor)
    {
        doctorRepo.Create(ToDoctor(newDoctor));
    }

    public DoctorDTO? GetDoctorById(int id)
    {
        return ToDoctorDTO(doctorRepo.GetById(id));
    }

    public List<DoctorDTO?> GetAllDoctors()
    {
        List<DoctorDTO?> doctorList = new();
        foreach (var doctor in doctorRepo.GetAll())
        {
            doctorList.Add(ToDoctorDTO(doctor));
        }
        return doctorList;
    }

    public void UpdateDoctor(DoctorDTO updatedDoctor)
    {
        doctorRepo.Update(ToDoctor(updatedDoctor));
    }

    public void DeleteDoctorById(int id)
    {
        doctorRepo.DeleteById(id);
    }

    private Doctor ToDoctor(DoctorDTO doctorDTO)
    {
        return new Doctor(
            doctorDTO.Id is null ? 0 : int.Parse(doctorDTO.Id),
            doctorDTO.FirstName,
            doctorDTO.LastName,
            doctorDTO.Specialization,
            doctorDTO.PhoneNumber,
            doctorDTO.Email
        );
    }

    private DoctorDTO? ToDoctorDTO(Doctor doctor)
    {
        return doctor is null ? null :
            new DoctorDTO(
                doctor.Id.ToString(),
                doctor.FirstName,
                doctor.LastName,
                doctor.Specialization,
                doctor.PhoneNumber,
                doctor.Email
            );
    }
}