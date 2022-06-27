using Microsoft.AspNetCore.Mvc;
using TestAikoProject.Lib.Interface;

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
}