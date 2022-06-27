using Microsoft.AspNetCore.Mvc;
using TestAikoProject.Lib.Interface;

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
}
