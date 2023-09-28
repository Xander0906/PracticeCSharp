using Microsoft.EntityFrameworkCore;
using MvcAspDotNet.Models;

namespace MvcAspDotNet.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
        public DbSet<ChatModel> ChatModels { get; set; }
        public DbSet<UserModel> UserModels { get; set; }

    }   
}
