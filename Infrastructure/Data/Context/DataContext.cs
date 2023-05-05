using Hackathon.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) 
        { 

        }

        public DbSet<ONG> ONGs { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Midia> Midias { get; set; }
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Especie> Especies { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Adaptacao> Adaptacoes { get; set; }
        public DbSet<Historico> Historicos { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<VeterinarioEndereco> VeterinariosEnderecos { get; set; }
        public DbSet<VeterinarioEspecialidade> VeterinariosEspecialidades { get; set; }

    }
}
