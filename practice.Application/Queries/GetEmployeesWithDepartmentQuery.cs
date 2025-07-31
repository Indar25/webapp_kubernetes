using MediatR;
using practice.Application.Dtos;

namespace practice.Application.Queries;
public record GetEmployeesWithDepartmentQuery(string Department) : IRequest<IEnumerable<Employee>>;

public class GetEmployeesWithDepartmentQueryHandler : IRequestHandler<GetEmployeesWithDepartmentQuery, IEnumerable<Employee>>
{
    public Task<IEnumerable<Employee>> Handle(GetEmployeesWithDepartmentQuery request, CancellationToken cancellationToken)
    {
        var departments = DummyData.GetDepartments();
        var employees = departments.Where(d => d.Name.Equals(request.Department, StringComparison.OrdinalIgnoreCase))
            .SelectMany(d => d.Employess)
            .ToList();

        return Task.FromResult<IEnumerable<Employee>>(employees);
    }
}
