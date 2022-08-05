using CJK.Service.ProductAPI.Model.Dto;
using Microsoft.EntityFrameworkCore;

namespace CJK.Service.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
