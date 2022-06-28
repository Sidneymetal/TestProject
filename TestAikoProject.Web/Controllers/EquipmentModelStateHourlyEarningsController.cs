using Microsoft.AspNetCore.Mvc;
using TestAikoProject.Lib.Interface;
using TestAikoProject.Lib.Models;
using TestAikoProject.Web.Dtos;

namespace TestAikoProject.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class EquipmentModelStateHourlyEarningController : ControllerBase
{
    protected readonly ILogger<EquipmentModelStateHourlyEarningController> _logger;
    protected readonly IEquipmentModelStateHourlyEarningRepository _repository;

    public EquipmentModelStateHourlyEarningController(ILogger<EquipmentModelStateHourlyEarningController> logger, IEquipmentModelStateHourlyEarningRepository repository)
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
    public IActionResult SetList(EquipmentModelStateHourlyEarningDTO equipmentModelStateHourlyEarningDTO)
    {
        var equipment = new EquipmentModelStateHourlyEarnings(equipmentModelStateHourlyEarningDTO.EquipmentModelId, equipmentModelStateHourlyEarningDTO.EquipmentModelId, equipmentModelStateHourlyEarningDTO.Value);
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