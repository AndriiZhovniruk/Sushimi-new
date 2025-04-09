using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sushimi.Models;
using System.Reflection.Emit;

namespace Sushimi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            Dish[] dishes = new Dish[32];
            dishes[0] = new Dish() { Id = 1, Category = "Sushi", Name = "California", Weight = 300, Price = 410 };
            dishes[1] = new Dish() { Id = 2, Category = "Sushi", Name = "California with Tuna", Weight = 290, Price = 520 };
            dishes[2] = new Dish() { Id = 3, Category = "Sushi", Name = "Enigma", Weight = 300, Price = 350 };
            dishes[3] = new Dish() { Id = 4, Category = "Sushi", Name = "Sakura", Weight = 290, Price = 480 };
            dishes[4] = new Dish() { Id = 5, Category = "Sushi", Name = "Felix with Crab", Weight = 305, Price = 380 };
            dishes[5] = new Dish() { Id = 6, Category = "Sushi", Name = "Itachi", Weight = 320, Price = 390 };
            dishes[6] = new Dish() { Id = 7, Category = "Sushi", Name = "Red Dragon", Weight = 325, Price = 530 };
            dishes[7] = new Dish() { Id = 8, Category = "Sushi", Name = "Philadelphia", Weight = 320, Price = 400 };

            dishes[8] = new Dish() { Id = 9, Category = "Sets", Name = "set 1", Weight = 600, Price = 1035 };
            dishes[9] = new Dish() { Id = 10, Category = "Sets", Name = "set 2", Weight = 895, Price = 1540 };
            dishes[10] = new Dish() { Id = 11, Category = "Sets", Name = "set 3", Weight = 950, Price = 1265 };
            dishes[11] = new Dish() { Id = 12, Category = "Sets", Name = "set 4", Weight = 2100, Price = 3300 };
            dishes[12] = new Dish() { Id = 13, Category = "Sets", Name = "set 5", Weight = 1600, Price = 2280 };
            dishes[13] = new Dish() { Id = 14, Category = "Sets", Name = "set 6", Weight = 650, Price = 1320 };

            dishes[14] = new Dish() { Id = 15, Category = "Hot", Name = "Beef udon noodles", Weight = 260, Price = 169 };
            dishes[15] = new Dish() { Id = 16, Category = "Hot", Name = "Funchoza with seafood", Weight = 250, Price = 245 };
            dishes[16] = new Dish() { Id = 17, Category = "Hot", Name = "Unagi chicken with rice", Weight = 280, Price = 155 };
            dishes[17] = new Dish() { Id = 18, Category = "Hot", Name = "Udon noodles with prawns", Weight = 370, Price = 245 };

            dishes[18] = new Dish() { Id = 19, Category = "Snacks", Name = "Inari", Weight = 65, Price = 140 };
            dishes[19] = new Dish() { Id = 20, Category = "Snacks", Name = "Sashimi", Weight = 155, Price = 480 };
            dishes[20] = new Dish() { Id = 21, Category = "Snacks", Name = "Tartar", Weight = 150, Price = 360 };
            dishes[21] = new Dish() { Id = 22, Category = "Snacks", Name = "Chuka", Weight = 185, Price = 230 };

            dishes[22] = new Dish() { Id = 23, Category = "Drinks", Name = "Coca-Cola", Weight = 0.5f, Price = 35 };
            dishes[23] = new Dish() { Id = 24, Category = "Drinks", Name = "Fanta", Weight = 0.5f, Price = 35 };
            dishes[24] = new Dish() { Id = 25, Category = "Drinks", Name = "Sprite", Weight = 0.5f, Price = 35 };
            dishes[25] = new Dish() { Id = 26, Category = "Drinks", Name = "Dr-Pepper", Weight = 0.5f, Price = 40 };
            dishes[26] = new Dish() { Id = 27, Category = "Drinks", Name = "Morshynska 1L", Weight = 1f, Price = 50 };
            dishes[27] = new Dish() { Id = 28, Category = "Drinks", Name = "Juice", Weight = 0.5f, Price = 50 };
            dishes[28] = new Dish() { Id = 29, Category = "Snacks", Name = "Shrimp shiso kimchi", Weight = 120, Price = 245 };
            dishes[29] = new Dish() { Id = 30, Category = "Snacks", Name = "Chips", Weight = 100, Price = 135 };
            dishes[30] = new Dish() { Id = 31, Category = "Hot", Name = "Ramen Spicy", Weight = 350, Price = 145 };
            dishes[31] = new Dish() { Id = 32, Category = "Drinks", Name = "Morshynska 0.5L", Weight = 0.5f, Price = 35 };

            builder.Entity<Dish>().HasData(dishes);

            builder.Entity<AdminUser>().HasData(
                new AdminUser { Id = 1, Username = "admin", Password = "admin123" });

        }
    }

}