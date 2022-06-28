using Microsoft.AspNetCore.Mvc;
using TestAikoProject.Lib.Interface;
using TestAikoProject.Lib.Models;
using TestAikoProject.Web.Dtos;

namespace TestAikoProject.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class EquipmentStateController : ControllerBase
{
    protected readonly ILogger<EquipmentStateController> _logger;
    protected readonly IEquipmentStateRepository _repository;

    public EquipmentStateController(ILogger<EquipmentStateController> logger, IEquipmentStateRepository repository)
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
    public IActionResult SetList(EquipmentStateDTO equipmentStateDTO)
    {
        var equipment = new EquipmentState(equipmentStateDTO.Id, equipmentStateDTO.Name, equipmentStateDTO.Color);
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