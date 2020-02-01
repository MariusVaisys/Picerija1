using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Picerija.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Pica> Picos { get; set; }
        public DbSet<Rusis> Rusys { get; set; }
        
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Uzsakymas> Uzsakymai { get; set; }
        public DbSet<UzsakymoInfo> UzsakymoInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed rusis
            modelBuilder.Entity<Rusis>().HasData(new Rusis { RusisId = 1, RusisPavadinimas = "Astri" });
            modelBuilder.Entity<Rusis>().HasData(new Rusis { RusisId = 2, RusisPavadinimas = "Vegetariska" });
            modelBuilder.Entity<Rusis>().HasData(new Rusis { RusisId = 3, RusisPavadinimas = "Soti" });

            //seed picos

            modelBuilder.Entity<Pica>().HasData(new Pica
            {
                PicaId = 1,
                Pavadinimas = "Margarita",
                Kaina = 7.99M,
                Sudetis = "Padas, suris, Desreles",
                RusisId = 3,
                ImageUrl = @"C:\Users\Marius\Desktop\C#Vakariniai mokymai\Picerija\Picerija\wwwroot\paveiksliukai\margarita.png",
                Pagaminta = true,
                Akcija = true,
                Alergenai = "A,B,C"
            });

            modelBuilder.Entity<Pica>().HasData(new Pica
            {
                PicaId = 2,
                Pavadinimas = "Salami",
                Kaina = 6.99M,
                Sudetis = "Padas, suris, Salami",
                RusisId = 1,
                ImageUrl = @"C:\Users\Marius\Desktop\C#Vakariniai mokymai\Picerija\Picerija\wwwroot\paveiksliukai\salami.png",
                Pagaminta = true,
                Akcija = true,
                Alergenai = "A,B,C"
            });

            modelBuilder.Entity<Pica>().HasData(new Pica
            {
                PicaId = 3,
                Pavadinimas = "Taiti",
                Kaina = 7.99M,
                Sudetis = "Padas, suris, Taiti",
                RusisId = 3,
                ImageUrl = @"C:\Users\Marius\Desktop\C#Vakariniai mokymai\Picerija\Picerija\wwwroot\paveiksliukai\margarita.png",
                Pagaminta = true,
                Akcija = true,
                Alergenai = "A,B,C"
            });
            modelBuilder.Entity<Pica>().HasData(new Pica
            {
                PicaId = 4,
                Pavadinimas = "Vegetariana",
                Kaina = 7.99M,
                Sudetis = "Padas, suris, Darzoves",
                RusisId = 2,
                ImageUrl = @"C:\Users\Marius\Desktop\C#Vakariniai mokymai\Picerija\Picerija\wwwroot\paveiksliukai\vegetariana.png",
                Pagaminta = true,
                Akcija = true,
                Alergenai = "A,B,C"
            });
        }
    }
}
