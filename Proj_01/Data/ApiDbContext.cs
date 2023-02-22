using Microsoft.EntityFrameworkCore;
using Proj_01.Models;

namespace Proj_01.Data
{
    public class ApiDbContext : DbContext
    {
        public virtual DbSet<User> Users {get;set;}
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) 
        { 
        }
    }
}
