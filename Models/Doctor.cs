using System.ComponentModel.DataAnnotations;

namespace Clinica.Models;

public class Doctor
{
    public Doctor()
    {
    }

    public Doctor(string firstName, string lastName, string specialization, string phoneNumber, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Specialization = specialization;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public Doctor(
        int id,
        string firstName,
        string lastName,
        string specialization,
        string phoneNumber,
        string email) : this(firstName, lastName, specialization, phoneNumber, email)
    {
        Id = id;
    }

    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Specialization { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
}