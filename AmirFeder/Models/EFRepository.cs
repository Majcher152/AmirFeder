using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmirFeder.Models
{
    public class EFRepository : IRepository
    {
        private ApplicationDbContext context;
        public EFRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;

        public IQueryable<Service> Services => context.Services;
    }
}
