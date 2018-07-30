using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmirFeder.Models
{
    // Repository's interface for Products and Services
    public interface IRepository 
    {
        IQueryable<Product> Products { get; }

        IQueryable<Service> Services { get; }
    }
}
