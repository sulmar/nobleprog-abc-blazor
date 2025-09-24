using Domain.Models;

namespace Domain.Abstractions;

public interface ICustomerRepository : IEntityRepository<Customer>
{
    Task<IEnumerable<Customer>> GetByTextAsync(string text);
}


public interface IMessageSender
{
    void Send(string message);
}