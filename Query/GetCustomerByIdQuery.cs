namespace MediatR.Demo.Query;

public class GetCustomerByIdQuery : IRequest<Customer>
{
    public Guid Id { get; set; }
}