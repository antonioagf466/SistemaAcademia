using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaAcademia.Areas.Identity.Data;
using SistemaAcademia.Models;

namespace SistemaAcademia.Data;

public class SistemaAcademiaContext : IdentityDbContext<SistemaAcademiaUser>
{
    public SistemaAcademiaContext(DbContextOptions<SistemaAcademiaContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<SistemaAcademia.Models.Aluno>? Aluno { get; set; }

    public DbSet<SistemaAcademia.Models.Aula>? Aula { get; set; }

    public DbSet<SistemaAcademia.Models.Equipamento>? Equipamento { get; set; }

    public DbSet<SistemaAcademia.Models.InscricaoAula>? InscricaoAula { get; set; }

    public DbSet<SistemaAcademia.Models.Manutencao>? Manutencao { get; set; }


    public DbSet<SistemaAcademia.Models.Pagamento>? Pagamento { get; set; }

    public DbSet<SistemaAcademia.Models.Plano>? Plano { get; set; }

    public DbSet<SistemaAcademia.Models.Professor>? Professor { get; set; }

    public DbSet<SistemaAcademia.Models.Sala>? Sala { get; set; }
    public object Aulas { get; internal set; }
}
