using MediatR.Demo.Entity;

public class CreateCustomerCommand : IRequest<Customer>
{
    public Customer Customer { get; set; }
}