using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiLibros.Models;

namespace WebApiLibros.Data
{
    public class DBLibroContext : DbContext
    {
        public DBLibroContext(DbContextOptions<DBLibroContext> options) : base(options) { }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }


    }
}
