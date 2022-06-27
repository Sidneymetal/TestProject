using Microsoft.AspNetCore.Mvc;
using TestAikoProject.Lib.Interface;

namespace TestAikoProject.Web.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class EquipmentStateHistoryController : ControllerBase
    {
        protected readonly ILogger<EquipmentStateHistoryController> _logger;
        protected readonly IEquipmentStateHistoryRepository _repository;

        public EquipmentStateHistoryController(ILogger<EquipmentStateHistoryController> logger, IEquipmentStateHistoryRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }
    }
}