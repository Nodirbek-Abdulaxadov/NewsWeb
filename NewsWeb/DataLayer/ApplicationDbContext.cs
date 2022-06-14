using Microsoft.EntityFrameworkCore;
using NewsWeb.Models;

namespace NewsWeb.DataLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<News> News { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasData(
                    new Category()
                    { 
                        Id = Guid.NewGuid(),
                        Name = "Global"
                    },
                    new Category()
                    {
                        Id = Guid.Parse("71624871-2fc9-4a0e-8aa5-6350f3acf4b8"),
                        Name = "IT"
                    },
                    new Category()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sport"
                    }
                );

            modelBuilder.Entity<News>()
                .HasData(
                    new News()
                    {
                        Id = Guid.NewGuid(),
                        Title = "Bootcamp Pro kursiga qabul davom etmoqda!",
                        Body = "✅ Endilikda yoshi 18 va undan yuqori bo'lganlar uchun kechki kurs ham tashkil etildi.  Ushbu kurs orqali Python, C++, Desktop dasturlash, mobil ilovalar yaratish va UI/UX dizaynlarini o'rganishingiz mumkin.",
                        PostedDate = DateTime.Now,
                        NumberOfViews = 0,
                        ImagePath = "photo_2022-06-10_21-25-43.jpg",
                        CategoryId = Guid.Parse("71624871-2fc9-4a0e-8aa5-6350f3acf4b8")
                    },
                    new News()
                    {
                        Id = Guid.NewGuid(),
                        Title = "Bootcamp Pro kursiga qabul davom etmoqda!",
                        Body = "✅ Endilikda yoshi 18 va undan yuqori bo'lganlar uchun kechki kurs ham tashkil etildi.  Ushbu kurs orqali Python, C++, Desktop dasturlash, mobil ilovalar yaratish va UI/UX dizaynlarini o'rganishingiz mumkin.",
                        PostedDate = DateTime.Now,
                        NumberOfViews = 0,
                        ImagePath = "photo_2022-06-10_21-25-43.jpg",
                        CategoryId = Guid.Parse("71624871-2fc9-4a0e-8aa5-6350f3acf4b8")
                    }
                );
        }
    }
}
