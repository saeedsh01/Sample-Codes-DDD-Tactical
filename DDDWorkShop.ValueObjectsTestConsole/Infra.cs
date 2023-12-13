using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDWorkShop.ValueObjectsTestConsole
{
    public class Infra
    {
    }

    public class FullName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return FirstName + "-" + LastName;
        }
        public static FullName CreateFromString(string fullName)
        {
            var split = fullName.Split('-');
            return new FullName { FirstName = split[0], LastName = split[1] };
        }
    }
    public class person
    {
        public int PersonId { get; set; }
        public FullName PersonFullName { get; set; }
    }
    public class PersonContext : DbContext
    {
        public DbSet<person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=PeopleDb;User ID=sa;Password=12345;Integrated Security=true;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<person>().OwnsOne(c => c.FullName);
            modelBuilder.Entity<person>().Property(c => c.PersonFullName).HasConversion(c => c.ToString(), d => FullName.CreateFromString(d));
            base.OnModelCreating(modelBuilder);

        }

    }
}
