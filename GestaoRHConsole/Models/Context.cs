﻿using Microsoft.EntityFrameworkCore;

namespace GestaoRHConsole.Models
{
    class Context : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=(localdb)\mssqllocaldb;
                    Database=GestaoRHConsole;
                    Trusted_Connection=true");
        }
    }
}
