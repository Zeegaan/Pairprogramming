using Microsoft.EntityFrameworkCore;
using PairProgramming.Models;

namespace PairProgramming.Data
{
    public class PersonContext : DbContext
    {
        public PersonContext (DbContextOptions<PersonContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; } = default!;
    }
}
