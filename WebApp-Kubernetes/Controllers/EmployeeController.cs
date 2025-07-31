using MediatR;
using Microsoft.AspNetCore.Mvc;
using practice.Application.Queries;

namespace WebApp_Kubernetes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var employees = await mediator.Send(new GetAllEmployeeQuery());
            return Ok(employees);
        }
        [HttpGet("GetEnvVariables")]
        public IActionResult GetEnvVariables()
        {
            var envVariables = new List<string>
            {
                Environment.GetEnvironmentVariable("DEPARTMENT_NAME") ?? "DEPARTMENT_NAME not set",
                Environment.GetEnvironmentVariable("COMPANY_NAME") ?? "COMPANY_NAME not set",
                Environment.GetEnvironmentVariable("LOCATION") ?? "LOCATION not set"
            };

            return Ok(envVariables);
        }
        [HttpGet("GetEmployeesWithSalaryRange")]
        public async Task<IActionResult> Get(decimal salary)
        {
            var employees = await mediator.Send(new GetEmployeesWithSalaryRangeQuery(salary));

            return Ok(employees);
        }

        [HttpGet("GetEmployeesWithDepartment")]
        public async Task<IActionResult> Get(string department)
        {
            var employees = await mediator.Send(new GetEmployeesWithDepartmentQuery(department));

            return Ok(employees);
        }
    }


}
