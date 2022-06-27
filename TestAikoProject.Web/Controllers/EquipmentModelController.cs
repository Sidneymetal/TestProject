using Microsoft.AspNetCore.Mvc;
using TestAikoProject.Lib.Interface;

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
}