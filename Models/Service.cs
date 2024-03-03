using System.ComponentModel.DataAnnotations;

namespace Clinica.Models;

public class Service
{
    public Service()
    {
    }

    public Service(string name, string desctiprion, int cost)
    {
        Name = name;
        Desctiprion = desctiprion;
        Cost = cost;
    }

    public Service(int id, string name, string desctiprion, int cost) :
    this(name, desctiprion, cost)
    {
        Id = id;
    }

    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Desctiprion { get; set; }
    public int Cost { get; set; }

}