using System.ComponentModel.DataAnnotations;

namespace Clinica.Models;

public class Patient
{
    public Patient()
    {
    }

    public Patient(
        string firstName,
        string lastName,
        DateOnly birthDay,
        string adress,
        string phoneNumber,
        ICollection<Disease>? diseases
        )
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDay = birthDay;
        Adress = adress;
        PhoneNumber = phoneNumber;
        Diseases = diseases;
    }

    public Patient(
        int id,
        string firstName,
        string lastName,
        DateOnly birthDay,
        string adress,
        string phoneNumber,
        ICollection<Disease>? diseases
        ) : this(firstName, lastName, birthDay, adress, phoneNumber, diseases)
    {
        Id = id;
    }

    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly BirthDay { get; set; }
    public string Adress { get; set; }
    public string PhoneNumber { get; set; }
    public ICollection<Disease>? Diseases { get; set; }
}