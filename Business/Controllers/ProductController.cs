using Business.Models;
using Business.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Business.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<ReadProductDto>>> SearchAll()
        {
            ICollection<Product> Products = await _productRepository.GetAll();
            return Ok(Products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReadProductDto>> SearchById(int id)
        {
            Product? product = await _productRepository.SearchById(id);

            if (product == null) return NotFound();

            ReadProductDto productReturn = new ReadProductDto()
            {
                Id = product.Id,
                Name = product.Name
            };

            return productReturn;
        }

        [HttpPost]
        public async Task<ReadProductDto> Add(CreateProductDto productDto)
        {
            Product product = new Product()
            {
                Name = productDto.Name
            };

            await _productRepository.Add(product);

            ReadProductDto productReturn = new ReadProductDto()
            {
                Id = product.Id,
                Name = product.Name
            };

            return productReturn;
        }

        [HttpPut("{id}")]
        public async Task<ReadProductDto> UpdateById(UpdateProductDto product, int id)
        {
            Product productItem = new Product()
            {
                Id = id,
                Name = product.Name
            };

            await _productRepository.Update(productItem, id);

            ReadProductDto updateReturn = new ReadProductDto()
            {
                Id = productItem.Id,
                Name = productItem.Name
            };

            return updateReturn;
        }

        [HttpDelete("{id}")]
        public async Task<Product> Delete(int id)
        {
            Product product = await _productRepository.Delete(id);
            return product;
        }
    }
}
