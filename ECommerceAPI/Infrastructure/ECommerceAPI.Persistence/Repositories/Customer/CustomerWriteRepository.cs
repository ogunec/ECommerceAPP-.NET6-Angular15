using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Repositories.Customer
{
    public class CustomerWriteRepository : WriteRepository<ECommerceAPI.Domain.Entities.Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(ApiDbContext context) : base(context)
        {
        }

    }
}
