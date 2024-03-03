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
        Diseases = diseases;
    }

    public PatientDTO(
            string? id,
            string firstName,
            string lastName,
            string birthDay,
            string adress,
            string phoneNumber,
            ICollection<string>? diseases
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
    public ICollection<string>? Diseases { get; set; }

    public Patient ToPatient()
    {
        if (Id is null)
        {
            return new Patient(
                FirstName,
                LastName,
                DateOnly.Parse(BirthDay),
                Adress,
                PhoneNumber,
                ToDiseases()
            );
        }
        return new Patient(
                int.Parse(Id),
                FirstName,
                LastName,
                DateOnly.Parse(BirthDay),
                Adress,
                PhoneNumber,
                ToDiseases()
            );
    }
    private ICollection<Disease> ToDiseases()
    {
        using (ApplicationContext context = new())
        {
            ICollection<Disease> diseases = new List<Disease>();
            foreach (var dis in Diseases)
            {
                Disease disease = context.Diseases
                    .Where(d => d.Desctiprion == dis).First();
                diseases.Add(disease);
            }
            return diseases;
        }
    }
}