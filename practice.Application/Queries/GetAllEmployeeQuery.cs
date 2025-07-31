using MediatR;
using practice.Application.Dtos;

namespace practice.Application.Queries;
public record GetAllEmployeeQuery : IRequest<IEnumerable<Employee>>;

public class GetAllEmployeeQueryHandler : IRequestHandler<GetAllEmployeeQuery, IEnumerable<Employee>>
{
    public Task<IEnumerable<Employee>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
    {
        var employees = DummyData.GetDepartments().SelectMany(x => x.Employess).ToList();
        return Task.FromResult<IEnumerable<Employee>>(employees);
    }
}

