using ECommerceAPI.Application.Repositories;
using Microsoft.EntityFrameworkCore;
using ECommerceAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories
{
    public class ProductWriteRepository : WriteRepository<ECommerceAPI.Domain.Entities.Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ApiDbContext context) : base(context)
        {
        }

        
    }
}
