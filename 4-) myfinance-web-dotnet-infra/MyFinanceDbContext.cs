using Microsoft.EntityFrameworkCore;
using myfinance_web_dotnet_domain.Entities;

namespace myfinance_web_dotnet_infra;

public class MyFinanceDbContext : DbContext
{
    public DbSet<PlanoConta> PlanoConta { get; set; }

    public DbSet<Transacao> Transacao { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {   
        // Exemplo de Conexão para Banco de Dados Local
        optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=myfinance;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=False;");
        // Exemplo de Conexão para Banco de Dados em Nuvem
        //optionsBuilder.UseSqlServer(@"Server=yourservename;Database=myfinance;User Id=user;Password=MyPassword");
    }
}
