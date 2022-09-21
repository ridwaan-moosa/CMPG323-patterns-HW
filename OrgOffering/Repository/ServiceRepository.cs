using OrgOffering.Data;
using OrgOffering.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace OrgOffering.Repository
{
    public class ServiceRepository : GenericRepository<Service>, IServiceRepository
    {
        public ServiceRepository(project3_hwContext context) : base(context)
        {
        }

        public Task GetById(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Service GetMostRecentService()
        {
            return _context.Service.OrderByDescending(service => service.CreatedDate).FirstOrDefault();
        }

        public Task Remove(Guid? id)
        {
            throw new NotImplementedException();
        }
    }
}
