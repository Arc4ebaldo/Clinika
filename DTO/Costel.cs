namespace Clinica.DTO;
public class Kostil
{
    public Kostil()
    {
    }

    public Kostil(string? id, string firstName, string lastName, string birthDay, string phoneNumber, string adress)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        BirthDay = birthDay;
        PhoneNumber = phoneNumber;
        Adress = adress;
    }

    public string? Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string BirthDay { get; set; }
    public string PhoneNumber { get; set; }
    public string Adress { get; set; }
}