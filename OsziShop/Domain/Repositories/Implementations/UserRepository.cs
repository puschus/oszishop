using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class UserRepository : ARepository<Account>
{
    public UserRepository(OsziDbContext context) : base(context)
    {
    }
}