using Business.Models;
using Business.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Business.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandRepository _brandRepository;

        public BrandController(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<ReadBrandDto>>> SearchAll()
        {
            ICollection<Brand> brands = await _brandRepository.GetAll();
            return Ok(brands);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReadBrandDto>> SearchById(int id)
        {
            Brand? brand = await _brandRepository.SearchById(id);

            if (brand == null) return NotFound();

            ReadBrandDto brandReturn = new ReadBrandDto()
            {
                Id = brand.Id,
                Name = brand.Name
            };

            return brandReturn;
        }

        [HttpPost]
        public async Task<ReadBrandDto> Add(CreateBrandDto brandDto)
        {
            Brand brand = new Brand()
            {
                Name = brandDto.Name
            };

            await _brandRepository.Add(brand);

            ReadBrandDto brandReturn = new ReadBrandDto()
            {
                Id = brand.Id,
                Name = brand.Name
            };

            return brandReturn;
        }

        [HttpPut("{id}")]
        public async Task<ReadBrandDto> UpdateById(UpdateBrandDto brand, int id)
        {
            Brand brandItem = new Brand()
            {
                Id = id,
                Name = brand.Name
            };

            await _brandRepository.Update(brandItem, id);

            ReadBrandDto updateReturn = new ReadBrandDto()
            {
                Id = brandItem.Id,
                Name = brandItem.Name
            };

            return updateReturn;
        }

        [HttpDelete("{id}")]
        public async Task<Brand> Delete(int id)
        {
            Brand brand = await _brandRepository.Delete(id);
            return brand;
        }
    }
}
