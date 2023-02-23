using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class OrderRepository : ARepository<Order>
{
    public OrderRepository(OsziDbContext context) : base(context)
    {
    }
}