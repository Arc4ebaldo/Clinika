using Clinica.Models;

namespace Clinica.DTO;

public class PatientDTO
{
    public PatientDTO()
    {
    }

    public PatientDTO(
            string firstName,
            string lastName,
            string birthDay,
            string adress,
            string phoneNumber,
            ICollection<string>? diseases
        )
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDay = birthDay;
        Adress = adress;
        PhoneNumber = phoneNumber;
    }

    public PatientDTO(
            string? id,
            string firstName,
            string lastName,
            string birthDay,
            string adress,
            string phoneNumber,
            ICollection<string?>? diseases
        ) : this(firstName, lastName, birthDay, adress, phoneNumber, diseases)
    {
        Id = id;
    }

    public string? Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string BirthDay { get; set; }
    public string Adress { get; set; }
    public string PhoneNumber { get; set; }
    public ICollection<string?>? Diseases { get; set; }
}