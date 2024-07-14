using MediatR;

namespace MrHRM.Application.Features.Department.Queries.List
{
    public class ListDepartmentCommandHandler : IRequestHandler<>
    {
        public Task<Unit> Handle(TRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
