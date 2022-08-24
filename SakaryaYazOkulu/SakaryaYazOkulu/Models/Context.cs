using Microsoft.EntityFrameworkCore;

namespace SakaryaYazOkulu.Models
{
    

        public class Context : DbContext
        {

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DENIZATMACA;Database=SakaryaWebDb; Integrated security=true;");
        }
           
            public DbSet<Admin> Admins { get; set; }
            public DbSet<Animal> Animals { get; set; }
            public DbSet<Owned> Owneds { get; set; }
            public DbSet<User> Users { get; set; }

        }


    
}
