using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Repositories.Order
{
    public class OrderWriteRepository : WriteRepository<ECommerceAPI.Domain.Entities.Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(ApiDbContext context) : base(context)
        {
        }

    }
}
