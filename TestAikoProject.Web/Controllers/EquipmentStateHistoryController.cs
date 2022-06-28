using Microsoft.AspNetCore.Mvc;
using TestAikoProject.Lib.Interface;
using TestAikoProject.Lib.Models;
using TestAikoProject.Web.Dtos;

namespace TestAikoProject.Web.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class EquipmentStateHistoryController : ControllerBase
    {
        protected readonly ILogger<EquipmentStateHistoryController> _logger;
        protected readonly IEquipmentStateHistoryRepository _repository;

        public EquipmentStateHistoryController(ILogger<EquipmentStateHistoryController> logger, IEquipmentStateHistoryRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            return Ok(_repository.GetAllList());
        }
        [HttpPost]
        public IActionResult SetList(EquipmentStateHistoryDTO equipmentStateHistoryDTO)
        {
            var equipment = new EquipmentStateHistory(equipmentStateHistoryDTO.EquipmentId, equipmentStateHistoryDTO.Date, equipmentStateHistoryDTO.EquipmentStatetId);
            _repository.SetAllList(equipment);
            return Ok();
        }
        [HttpPut]
        public IActionResult ChangeList(Guid id, Equipment equipment)
        {
            _repository.ChangeList(id, equipment);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Detele(Guid id)
        {
            _repository.Delete(id);
            return Ok();
        }
    }
}