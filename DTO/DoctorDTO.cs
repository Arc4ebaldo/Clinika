using Clinica.Models;

namespace Clinica.DTO;

public class DoctorDTO
{
    public DoctorDTO()
    {
    }

    public DoctorDTO(
            string firstName,
            string lastName,
            string specialization,
            string phoneNumber,
            string email
        )
    {
        FirstName = firstName;
        LastName = lastName;
        Specialization = specialization;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public DoctorDTO(
            string? id,
            string firstName,
            string lastName,
            string specialization,
            string phoneNumber,
            string email
        ) : this(firstName, lastName, specialization, phoneNumber, email)
    {
        Id = id;
    }

    public string? Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Specialization { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
}