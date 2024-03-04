namespace Clinica.DTO;
public class Kostil
{
    public Kostil()
    {
    }

    public Kostil(string? id, string firstName, string lastName, string birthDay, string adress, string phoneNumber)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        BirthDay = birthDay;
        Adress = adress;
        PhoneNumber = phoneNumber;
    }

    public string? Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string BirthDay { get; set; }
    public string Adress { get; set; }
    public string PhoneNumber { get; set; }
}