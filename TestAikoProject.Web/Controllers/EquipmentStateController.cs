using Microsoft.AspNetCore.Mvc;
using TestAikoProject.Lib.Interface;

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
}