using ECommerceAPI.Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;
        public ProductController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }
        [HttpGet]
        public async void Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new(){id = Guid.NewGuid(), Name = "Product 1", Stock = 100, Price = 500, CreatedDate = DateTime.UtcNow },
                new(){id = Guid.NewGuid(), Name = "Product 2", Stock = 200, Price = 600, CreatedDate = DateTime.UtcNow },
                new(){id = Guid.NewGuid(), Name = "Product 3", Stock = 300, Price = 700, CreatedDate = DateTime.UtcNow }
            });
            await _productWriteRepository.SaveAsync();
        }
    }
}
