using Clinica.Models;

namespace Clinica.Repositories;

public class ServiceRepo
{
    private ApplicationContext context;
    public ServiceRepo()
    {
        context = new();
    }

    public void Create(Service newService)
    {
        context.Services.Add(newService);
        context.SaveChanges();
    }

    public Service? GetServiceById(int id)
    {
        return context.Services.Find(id);
    }

    public IEnumerable<Service>? GetAll()
    {
        return context.Services.AsEnumerable();
    }

    public void Update(Service updatedService)
    {
        Service? serviceToUpdate = context.Services.Find(updatedService.Id);
        serviceToUpdate.Name = updatedService.Name;
        serviceToUpdate.Cost = updatedService.Cost;
        serviceToUpdate.Desctiprion = updatedService.Desctiprion;
        context.SaveChanges();
    }
    public void DeleteById(int id)
    {
        context.Services
            .Remove(context.Services.Find(id));
        context.SaveChanges();
    }
}