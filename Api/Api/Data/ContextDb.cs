using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions options) : base(options)
        {
        }
    }
}
