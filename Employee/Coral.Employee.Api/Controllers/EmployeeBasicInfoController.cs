using Microsoft.AspNetCore.Mvc;
using Coral.Employee.Domain;
using Coral.Employee.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coral.Employee.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeBasicInfoController : ControllerBase
    {
        private readonly IEmployeeBasicInfoService _employeeBasicInfoService;

        public EmployeeBasicInfoController(IEmployeeBasicInfoService employeeBasicInfoService)
        {
            _employeeBasicInfoService = employeeBasicInfoService;
        }

        [HttpGet("all")]
        public async Task<List<EmployeeCompositeInfo>> GetAll()
        {
            return await _employeeBasicInfoService.GetAllEmployeeBasicInfo();
        }
    }
}
