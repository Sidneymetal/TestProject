using Microsoft.AspNetCore.Mvc;
using TestAikoProject.Lib.Interface;

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
}