using Microsoft.EntityFrameworkCore;

namespace DoAnTotNghiep.Models.Service
{
    public static class InitDatabase
    {
        public static void Khoitao(this ModelBuilder b)
        {
            b.Entity<Category>().HasData(
                new Category {  Id = 1,  Name="Nike"},
                new Category {  Id = 2, Name ="Joden"},
                new Category {  Id = 3, Name ="Navada"},
                new Category {  Id = 4, Name = "sdfl" }
                );
            b.Entity<GenericShoes>().HasData(
                new GenericShoes { Id = 1, Name="Nike so 1", Details="...",Category_ID=1,},
                new GenericShoes { Id = 2, Name = "Nike so 2", Details = "...", Category_ID = 1, },
                new GenericShoes { Id = 3, Name = "Joden so 1", Details = "...", Category_ID = 2, }

                );
        }
    }
}
