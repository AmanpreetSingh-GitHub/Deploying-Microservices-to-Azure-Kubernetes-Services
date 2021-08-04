using Microsoft.AspNetCore.Mvc;
using Coral.MasterData.Persistance.Entities;
using Coral.MasterData.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coral.MasterData.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeStatusController : ControllerBase
    {
        private readonly IEmployeeStatusService _employeeStatusService;

        public EmployeeStatusController(IEmployeeStatusService employeeStatusService)
        {
            _employeeStatusService = employeeStatusService;
        }

        [HttpGet("all")]
        public async Task<List<EmployeeStatus>> GetAll()
        {
            return await _employeeStatusService.GetAll();
        }
    }
}
