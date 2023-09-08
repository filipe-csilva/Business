using Business.Models;
using Business.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Business.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;

        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<ReadClientDto>>> SearchAll()
        {
            ICollection<Client> Clients = await _clientRepository.GetAll();
            return Ok(Clients);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReadClientDto>> SearchById(int id)
        {
            Client? Client = await _clientRepository.SearchById(id);

            if (Client == null) return NotFound();

            ReadClientDto ClientReturn = new ReadClientDto()
            {
                Id = Client.Id,
                Name = Client.Name,
                CPF = Client.CPF,
                Address = Client.Address,
                Number = Client.Number,
                Borhood = Client.Borhood,
                City = Client.City,
                Region = Client.Region,
                PostalCode = Client.PostalCode,
                Fone = Client.Fone
            };

            return ClientReturn;
        }

        [HttpPost]
        public async Task<ReadClientDto> Add(CreateClientDto ClientDto)
        {
            Client Client = new Client()
            {
                Name = ClientDto.Name,
                CPF = ClientDto.CPF,
                Address = ClientDto.Address,
                Number = ClientDto.Number,
                Borhood = ClientDto.Borhood,
                City = ClientDto.City,
                Region = ClientDto.Region,
                PostalCode = ClientDto.PostalCode,
                Fone = ClientDto.Fone
            };

            await _clientRepository.Add(Client);

            ReadClientDto ClientReturn = new ReadClientDto()
            {
                Id = Client.Id,
                Name = Client.Name,
                CPF = Client.CPF,
                Address = Client.Address,
                Number = Client.Number,
                Borhood = Client.Borhood,
                City = Client.City,
                Region = Client.Region,
                PostalCode = Client.PostalCode,
                Fone = Client.Fone
            };

            return ClientReturn;
        }

        [HttpPut("{id}")]
        public async Task<ReadClientDto> UpdateById(UpdateClientDto Client, int id)
        {
            Client ClientItem = new Client()
            {
                Id = id,
                Name = Client.Name,
                CPF = Client.CPF,
                Address = Client.Address,
                Number = Client.Number,
                Borhood = Client.Borhood,
                City = Client.City,
                Region = Client.Region,
                PostalCode = Client.PostalCode,
                Fone = Client.Fone
            };

            await _clientRepository.Update(ClientItem, id);

            ReadClientDto updateReturn = new ReadClientDto()
            {
                Id = ClientItem.Id,
                Name = ClientItem.Name,
                CPF = ClientItem.CPF,
                Address = ClientItem.Address,
                Number = ClientItem.Number,
                Borhood = ClientItem.Borhood,
                City = ClientItem.City,
                Region = ClientItem.Region,
                PostalCode = ClientItem.PostalCode,
                Fone = ClientItem.Fone
            };

            return updateReturn;
        }

        [HttpDelete("{id}")]
        public async Task<Client> Delete(int id)
        {
            Client Client = await _clientRepository.Delete(id);
            return Client;
        }
    }
}
