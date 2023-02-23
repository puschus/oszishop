using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class WebshopRepository : ARepository<Webshop>
{
    public WebshopRepository(OsziDbContext context) : base(context)
    {
    }
}