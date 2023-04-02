using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Repositories.Customer
{
    public class CustomerReadRepository : ReadRepository<ECommerceAPI.Domain.Entities.Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(ApiDbContext context) : base(context)
        {
        }

    }
}
