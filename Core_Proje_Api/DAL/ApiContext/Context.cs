using Core_Proje_Api.DAL.Entitiy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje_Api.DAL.ApiContext
{
    public class Context :DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-FA6RBVRG; database=CoreProjeDB22 ; integrated security=true");
        }

        public DbSet<Category> Categories { get; set; }
    }
}
