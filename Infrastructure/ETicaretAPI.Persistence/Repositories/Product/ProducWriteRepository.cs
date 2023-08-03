using EticaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories
{
    public class ProducWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProducWriteRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
