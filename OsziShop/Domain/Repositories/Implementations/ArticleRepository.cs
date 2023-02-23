using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class ArticleRepository : ARepository<Article>
{
    public ArticleRepository(OsziDbContext context) : base(context)
    {
    }
}