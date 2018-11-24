using Microsoft.EntityFrameworkCore;
using SiteMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteMvc.Database
{
    public class DatabaseContext : DbContext
    {
        //Criando a tabela na base baseada no modelo
        public DbSet<Palavra> Palavras { get; set; }

        public DatabaseContext( DbContextOptions<DatabaseContext> options) : base (options)
        {
            //EF : Garantir a criaçção do banco - Code First
            Database.EnsureCreated();
        }
    }
}
