using EntityModelTest.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityModelTest
{
    public class ClassroomContext : DbContext
    {
        public ClassroomContext() : base("name = ClassroomContext")
        {

        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<Classes> Classes { get; set; }
        public DbSet<Discontinuities> Discontinuities { get; set; }
        public DbSet<Grades> Grades { get; set; }
        public DbSet<Lessons> Lessons { get; set; }
        public DbSet<Logins> Logins { get; set; }
        public DbSet<Management> Management { get; set; }
    }
}
