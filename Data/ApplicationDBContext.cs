using finshark.Models;
using Microsoft.EntityFrameworkCore;

namespace finshark.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {}

        public required DbSet<Stock> Stocks { get; set; }
        public required DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            try
            {
                base.OnModelCreating(model);
            }
            catch (Exception error)
            {
                throw new Exception($"Error : {error.Message}");
            }
        }
    }
}