using EntityFrameworkApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkApi.Context
{
    public class EntityFrameworkContext : DbContext
    {

        public DbSet<Developers> Developers { get; set; }

        public EntityFrameworkContext(DbContextOptions<EntityFrameworkContext> options)
               : base(options)
        {

        }




    }
}
