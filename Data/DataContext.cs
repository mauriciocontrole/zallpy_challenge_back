using Microsoft.EntityFrameworkCore;
using zallpy_challenge_back.Models;

namespace zallpy_challenge_back.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {
        }
        public DbSet<Question> Questions { get; set; }
    }
}