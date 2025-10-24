namespace MediatR.Demo.Command;
namespace MediatR.Demo.Command;

public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Customer>
{
    private readonly IRepository<Customer> _repository;

    public CreateCustomerCommandHandler(IRepository<Customer> repository)
    {
        _repository = repository;
    }

    public async Task<Customer> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        return await _repository.AddAsync(request.Customer);
    }
}