using Microsoft.EntityFrameworkCore;

namespace DoAnTotNghiep.Models.Service
{
    public class Context : DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<GenericShoes> GenericShoes { get; set; }
        public virtual DbSet<Specific_Shoes> SpecificShoes { get; set; }
        public virtual DbSet<Sizes> Sizes { get; set; }
        public virtual DbSet<Colors> Color { get; set; }

        public Context(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder b)
        {
            b.Khoitao();
        }

    }
}
