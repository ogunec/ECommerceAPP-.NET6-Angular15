using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Repositories.Product
{
    public class ProductReadRepository : ReadRepository<ECommerceAPI.Domain.Entities.Product>, IProductReadRepository
    {
        public ProductReadRepository(ApiDbContext context) : base(context)
        {
        }

        
    }
}
