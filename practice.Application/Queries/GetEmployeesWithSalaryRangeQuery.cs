using MediatR;
using practice.Application.Dtos;

namespace practice.Application.Queries
{
    public record GetEmployeesWithSalaryRangeQuery(decimal Salary) : IRequest<IEnumerable<Employee>>;
    public class GetEmployeesWithSalaryRangeQueryHanler : IRequestHandler<GetEmployeesWithSalaryRangeQuery, IEnumerable<Employee>>
    {
        public Task<IEnumerable<Employee>> Handle(GetEmployeesWithSalaryRangeQuery request, CancellationToken cancellationToken)
        {
            var employees = DummyData.GetDepartments()
                    .SelectMany(x => x.Employess)
                    .Where(e => e.Salary > request.Salary)
                    .ToList();

            return Task.FromResult<IEnumerable<Employee>>(employees);
        }
    }
}
