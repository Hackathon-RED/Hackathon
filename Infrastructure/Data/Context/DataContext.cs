using Hackathon.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) 
        { 

        }

        public DbSet<Midia> Midias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<VeterinarioEndereco> VeterinariosEnderecos { get; set; }
        public DbSet<VeterinarioEspecialidade> VeterinariosEspecialidades { get; set; }

    }
}
