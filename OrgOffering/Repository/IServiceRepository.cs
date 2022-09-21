using OrgOffering.Data;
using OrgOffering.Models;
using System;
using System.Threading.Tasks;

namespace OrgOffering.Repository
{
    public interface IServiceRepository : IGenericRepository<Service>
    {
        Service GetMostRecentService();
        Task GetById(Guid? id);
        Task Remove(Guid? id);
    }
}
