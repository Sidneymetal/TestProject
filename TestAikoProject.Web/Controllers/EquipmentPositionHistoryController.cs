using Microsoft.AspNetCore.Mvc;
using TestAikoProject.Lib.Interface;
using TestAikoProject.Lib.Models;
using TestAikoProject.Web.Dtos;

namespace TestAikoProject.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class EquipmentPositionHistoryController : ControllerBase
{
    protected readonly ILogger<EquipmentPositionHistoryController> _logger;
    protected readonly IEquipmentPositionHistoryRepository _repository;

    public EquipmentPositionHistoryController(ILogger<EquipmentPositionHistoryController> logger, IEquipmentPositionHistoryRepository repository)
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
    public IActionResult SetList(EquipmentPositionHistoryDTO equipmentPositionHistoryDTO)
    {
        var equipment = new EquipmentPositionHistory(equipmentPositionHistoryDTO.EquipmentId, equipmentPositionHistoryDTO.Date, equipmentPositionHistoryDTO.Lat, equipmentPositionHistoryDTO.Lon);
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