using Microsoft.EntityFrameworkCore;
using WebapiEVO.Models;

namespace WebapiEVO.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {
            
        }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        
        // protected override void OnModelCreating(ModelBuilder builder)
        // {
        //     builder.Entity<Funcionario>()
        //         .HasKey(x => x.ID);
        // }

    }
}