using Business.Models;
using Business.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Business.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class SubGroupController : ControllerBase
    {
        private readonly ISubGroupRepository _subgroupRepository;

        public SubGroupController(ISubGroupRepository groupRepository)
        {
            _subgroupRepository = groupRepository;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<ReadSubGroupDto>>> SearchAll()
        {
            ICollection<SubGroup> groups = await _subgroupRepository.GetAll();
            return Ok(groups);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReadSubGroupDto>> SearchById(int id)
        {
            SubGroup? group = await _subgroupRepository.SearchById(id);

            if (group == null) return NotFound();

            ReadSubGroupDto groupReturn = new ReadSubGroupDto()
            {
                Id = group.Id,
                Name = group.Name,
                GroupId = group.GroupId,
                Group = group.Group
            };

            return groupReturn;
        }

        [HttpPost]
        public async Task<ReadSubGroupDto> Add(CreateSubGroupDto groupDto)
        {
            SubGroup group = new SubGroup()
            {
                Name = groupDto.Name,
                GroupId = groupDto.GroupId
            };

            await _subgroupRepository.Add(group);

            ReadSubGroupDto groupReturn = new ReadSubGroupDto()
            {
                Id = group.Id,
                Name = group.Name,
                GroupId = group.GroupId
            };

            return groupReturn;
        }

        [HttpPut("{id}")]
        public async Task<ReadSubGroupDto> UpdateById(UpdateSubGroupDto group, int id)
        {
            SubGroup groupItem = new SubGroup()
            {
                Id = id,
                Name = group.Name,
                GroupId = group.GroupId
            };

            await _subgroupRepository.Update(groupItem, id);

            ReadSubGroupDto updateReturn = new ReadSubGroupDto()
            {
                Id = groupItem.Id,
                Name = groupItem.Name,
                GroupId = groupItem.GroupId
            };

            return updateReturn;
        }

        [HttpDelete("{id}")]
        public async Task<SubGroup> Delete(int id)
        {
            SubGroup? group = await _subgroupRepository.Delete(id);
            return group;
        }
    }
}
