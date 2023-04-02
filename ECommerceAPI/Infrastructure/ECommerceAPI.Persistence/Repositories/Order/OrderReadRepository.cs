using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Repositories.Order
{
    public class OrderReadRepository : ReadRepository<ECommerceAPI.Domain.Entities.Order>, IOrderReadRepository
    {
        public OrderReadRepository(ApiDbContext context) : base(context)
        {
        }

    }
}
