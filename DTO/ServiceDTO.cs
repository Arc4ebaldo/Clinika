using System.CodeDom;
using Clinica.Models;

namespace Clinica.DTO;

public class ServiceDTO
{
    public ServiceDTO()
    {
    }

    public ServiceDTO(
            string name,
            string desctiprion,
            string cost
        )
    {
        Name = name;
        Description = desctiprion;
        Cost = cost;
    }

    public ServiceDTO(
            string? id,
            string name,
            string desctiprion,
            string cost
        ) : this(name, desctiprion, cost)
    {
        Id = id;
    }

    public string? Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Cost { get; set; }
}