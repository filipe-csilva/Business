using Business.Models;
using Business.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Business.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IGroupRepository _groupRepository;

        public GroupController(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<ReadGroupDto>>> SearchAll()
        {
            ICollection<Group> groups = await _groupRepository.GetAll();
            return Ok(groups);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReadGroupDto>> SearchById(int id)
        {
            Group? group = await _groupRepository.SearchById(id);

            if (group == null) return NotFound();

            ReadGroupDto groupReturn = new ReadGroupDto()
            {
                Id = group.Id,
                Name = group.Name
            };

            return groupReturn;
        }

        [HttpPost]
        public async Task<ReadGroupDto> Add(CreateGroupDto groupDto)
        {
            Group group = new Group()
            {
                Name = groupDto.Name
            };

            await _groupRepository.Add(group);

            ReadGroupDto groupReturn = new ReadGroupDto()
            {
                Id = group.Id,
                Name = group.Name
            };

            return groupReturn;
        }

        [HttpPut("{id}")]
        public async Task<ReadGroupDto> UpdateById(UpdateGroupDto group, int id)
        {
            Group groupItem = new Group()
            {
                Id = id,
                Name = group.Name
            };

            await _groupRepository.Update(groupItem, id);

            ReadGroupDto updateReturn = new ReadGroupDto()
            {
                Id = groupItem.Id,
                Name = groupItem.Name
            };

            return updateReturn;
        }

        [HttpDelete("{id}")]
        public async Task<Group> Delete(int id)
        {
            Group group = await _groupRepository.Delete(id);
            return group;
        }
    }
}
