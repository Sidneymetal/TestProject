using Microsoft.AspNetCore.Mvc;
using TestAikoProject.Lib.Interface;
using TestAikoProject.Lib.Models;
using TestAikoProject.Web.Dtos;

namespace TestAikoProject.Web.Controllers;

[ApiController]

[Route("[controller]")]
public class EquipmentController : ControllerBase
{
    protected readonly ILogger<EquipmentController> _logger;
    protected readonly IEquipmentRepository _repository;

    public EquipmentController(ILogger<EquipmentController> logger, IEquipmentRepository repository)
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
    public IActionResult SetList(EquipmentDTO equipmentDTO)
    {
        var equipment = new Equipment(equipmentDTO.Id, equipmentDTO.EquipmentModelId, equipmentDTO.Name);
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
