using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace lab_pc1_campos.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

         public DbSet<lab_pc1_campos.Models.Formulario> Contactos { get; set; }
    }
}