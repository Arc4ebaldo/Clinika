using Clinica.DTO;
using Clinica.Models;
using Clinica.Repositories;

namespace Clinica.Services;

public class ServiceService
{
    private ServiceRepo Repo;

    public ServiceService()
    {
        Repo = new();
    }

    public void CreateService(ServiceDTO newService)
    {
        Repo.Create(new Service(
            newService.Name,
            newService.Desctiprion,
            int.Parse(newService.Cost)
        ));
    }

    public ServiceDTO? GetServiceById(int id)
    {
        Service? service = Repo.GetServiceById(id);
        return ToServiceDTO(service);
    }

    public List<ServiceDTO> GetAllServices()
    {
        List<ServiceDTO> serviceList = new();
        foreach (var service in Repo.GetAll())
        {
            serviceList.Add(ToServiceDTO(service));
        }
        return serviceList;
    }

    public void UpdateService(ServiceDTO updatedService)
    {
        Repo.Update(ToService(updatedService));
    }

    public void DeleteServiceById(int id)
    {
        Repo.DeleteById(id);
    }

    private Service ToService(ServiceDTO serviceDTO)
    {
        return new Service(
            serviceDTO.Id is null ? 0:int.Parse(serviceDTO.Id),
            serviceDTO.Name,
            serviceDTO.Desctiprion,
            int.Parse(serviceDTO.Cost)
        );
    }

    private ServiceDTO? ToServiceDTO(Service service)
    {
        return new ServiceDTO(
            service.Id.ToString(),
            service.Name,
            service.Desctiprion,
            service.Cost.ToString()
        );
    }
}