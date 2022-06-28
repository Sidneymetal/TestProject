using Microsoft.AspNetCore.Mvc;
using TestAikoProject.Lib.Interface;
using TestAikoProject.Lib.Models;
using TestAikoProject.Web.Dtos;

namespace TestAikoProject.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class EquipmentModelController : ControllerBase
{
    protected readonly ILogger<EquipmentModelController> _logger;
    protected readonly IEquipmentModelRepository _repository;

    public EquipmentModelController(ILogger<EquipmentModelController> logger, IEquipmentModelRepository repository)
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
    public IActionResult SetList(EquipmentModelDTO equipmentModelDTO)
    {
        var equipment = new EquipmentModel(equipmentModelDTO.Id, equipmentModelDTO.Name);
        _repository.SetAllList(equipment);
        return Ok();
    }
    [HttpPut()]
    public IActionResult ChangeList(Guid id, Equipment equipment)
    {
        _repository.ChangeList(id, equipment);
        return Ok();
    }
    [HttpDelete("{id}")]
    public IActionResult Detele(Guid id)
    {
        _repository.Delete(id);
        return Ok();
    }
}