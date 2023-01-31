using Microsoft.EntityFrameworkCore;
using University_API_Backend.Models.DataModels;

namespace University_API_Backend.DataAccess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options) 
        {

        }

        // To do: Add DbSets (tables of our database)
        public DbSet<User>? Users { get; set; }

    }
}
