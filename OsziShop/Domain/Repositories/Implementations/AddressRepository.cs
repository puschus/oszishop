using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class AddressRepository : ARepository<Address>
{
    public AddressRepository(OsziDbContext context) : base(context)
    {
    }
}