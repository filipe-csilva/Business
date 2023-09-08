using Business.Models;
using Business.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Business.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierController(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<ReadSupplierDto>>> SearchAll()
        {
            ICollection<Supplier> suppliers = await _supplierRepository.GetAll();
            return Ok(suppliers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReadSupplierDto>> SearchById(int id)
        {
            Supplier? supplier = await _supplierRepository.SearchById(id);

            if (supplier == null) return NotFound();

            ReadSupplierDto supplierReturn = new ReadSupplierDto()
            {
                Id = supplier.Id,
                Name = supplier.Name,
                CNPJ = supplier.CNPJ,
                IE = supplier.IE,
                Address = supplier.Address,
                Number = supplier.Number,
                Borhood = supplier.Borhood,
                City = supplier.City,
                Region = supplier.Region,
                PostalCode = supplier.PostalCode,
                Fone = supplier.Fone
            };

            return supplierReturn;
        }

        [HttpPost]
        public async Task<ReadSupplierDto> Add(CreateSupplierDto supplierDto)
        {
            Supplier supplier = new Supplier()
            {
                Name = supplierDto.Name,
                CNPJ = supplierDto.CNPJ,
                IE = supplierDto.IE,
                Address = supplierDto.Address,
                Number = supplierDto.Number,
                Borhood = supplierDto.Borhood,
                City = supplierDto.City,
                Region = supplierDto.Region,
                PostalCode = supplierDto.PostalCode,
                Fone = supplierDto.Fone
            };

            await _supplierRepository.Add(supplier);

            ReadSupplierDto supplierReturn = new ReadSupplierDto()
            {
                Id = supplier.Id,
                Name = supplier.Name,
                CNPJ = supplier.CNPJ,
                IE = supplier.IE,
                Address = supplier.Address,
                Number = supplier.Number,
                Borhood = supplier.Borhood,
                City = supplier.City,
                Region = supplier.Region,
                PostalCode = supplier.PostalCode,
                Fone = supplier.Fone
            };

            return supplierReturn;
        }

        [HttpPut("{id}")]
        public async Task<ReadSupplierDto> UpdateById(UpdateSupplierDto supplier, int id)
        {
            Supplier supplierItem = new Supplier()
            {
                Id = id,
                Name = supplier.Name,
                CNPJ = supplier.CNPJ,
                IE = supplier.IE,
                Address = supplier.Address,
                Number = supplier.Number,
                Borhood = supplier.Borhood,
                City = supplier.City,
                Region = supplier.Region,
                PostalCode = supplier.PostalCode,
                Fone = supplier.Fone
            };

            await _supplierRepository.Update(supplierItem, id);

            ReadSupplierDto updateReturn = new ReadSupplierDto()
            {
                Id = supplierItem.Id,
                Name = supplierItem.Name,
                CNPJ = supplierItem.CNPJ,
                IE = supplierItem.IE,
                Address = supplierItem.Address,
                Number = supplierItem.Number,
                Borhood = supplierItem.Borhood,
                City = supplierItem.City,
                Region = supplierItem.Region,
                PostalCode = supplierItem.PostalCode,
                Fone = supplierItem.Fone
            };

            return updateReturn;
        }

        [HttpDelete("{id}")]
        public async Task<Supplier> Delete(int id)
        {
            Supplier supplier = await _supplierRepository.Delete(id);
            return supplier;
        }
    }
}
