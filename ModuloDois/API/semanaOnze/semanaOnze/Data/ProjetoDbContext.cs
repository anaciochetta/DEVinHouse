using Microsoft.EntityFrameworkCore;
using semanaOnze.Models;

namespace semanaOnze.Data;

public class ProjetoDbContext : DbContext
{
    //recupera (do appsettings.D) string de conexão de banco por injeção de dependência
    private IConfiguration _configuration;
    public ProjetoDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    //quais as tabelas vão ter no modelo de dados
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<CarteiraTrabalho> CarteirasTrabalho { get; set; }
    public DbSet<Vacina> Vacinas { get; set; }
    public DbSet<ClienteVacina> ClientesVacinas { get; set; }
    public DbSet<Exame> Exames { get; set; }

    //especifica qual o provedor de banco que vai usar e qual a string de conexão
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("CONEXAO_BANCO"));
    }

    //declarar os mapeamentos da aplicação de forma explicita
    //método de como o contexto vai ser mapeado para o banco de dados
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //importante chamar isso!!!
        base.OnModelCreating(modelBuilder);

        // Cliente
        modelBuilder.Entity<Cliente>()
            .ToTable("Clientes"); //muda o nome na tabela

        modelBuilder.Entity<Cliente>()
            .HasKey(c => c.Id); //a chave da tabela

        modelBuilder.Entity<Cliente>()
            .Property(c => c.Nome) //propriedade mapeada da classe
            .HasMaxLength(200) //tamanho do nome
            .IsRequired(); //obrigatório

        modelBuilder.Entity<Cliente>()
            .Property(c => c.DataNascimento);

        // mapeamento da relação de um pra um
        modelBuilder.Entity<Cliente>() // o cliente
            .HasOne<CarteiraTrabalho>(cliente => cliente.CarteiraTrabalho) //possui um do tipo ct - dentro do cliente oq representa a ct
            .WithOne(c => c.Cliente) //possui um do tipo cliente - dentro da ct oq representa o cliente
            .HasForeignKey<CarteiraTrabalho>(c => c.ClienteId); //chave estrangeira da relação - ct que possui a fk

        // Carteira de trabalho
        modelBuilder.Entity<CarteiraTrabalho>()
            .ToTable("CarteirasTrabalho");

        modelBuilder.Entity<CarteiraTrabalho>()
            .HasKey(c => c.Id);

        modelBuilder.Entity<CarteiraTrabalho>()
            .Property(c => c.PisPasep)
            .HasMaxLength(20)
            .IsRequired();

        // Exame
        modelBuilder.Entity<Exame>()
            .ToTable("Exames");

        modelBuilder.Entity<Exame>()
            .HasKey(e => e.Id);

        modelBuilder.Entity<Exame>()
            .Property(e => e.CodigoTuss)
            .HasMaxLength(20);

        modelBuilder.Entity<Exame>()
            .Property(e => e.DataAgendamento)
            .IsRequired(); //sempre tem a data de agendamento

        // mapeamento 1 pra N
        modelBuilder.Entity<Exame>() //o exame
            .HasOne<Cliente>(e => e.Cliente) //possui 1 do tipo cliente - dentro do exame oq representa o cliente
            .WithMany(c => c.Exames) //possui N do tipo exame - dentro do cliente oq representa o exame - navegação inversa
            .HasForeignKey(e => e.ClienteId) //chave estrangeira da relação - exame que possui a fk
            .OnDelete(DeleteBehavior.Restrict); //não pode excluir o cliente se já tiver exames cadastrados

        // Vacina
        modelBuilder.Entity<Vacina>()
            .ToTable("Vacinas");

        modelBuilder.Entity<Vacina>()
            .HasKey(v => v.Id);

        modelBuilder.Entity<Vacina>()
            .Property(v => v.Nome)
            .IsRequired()
            .HasMaxLength(200);

        modelBuilder.Entity<Vacina>() //a vacina
            .Property(v => v.NumeroDoses) //tem a propriedade mapeada com o nome
            .IsRequired() //que é obrigatória
            .HasDefaultValue(1); //e tem como padrão uma dose

        modelBuilder.Entity<Vacina>()
        //predefine alguns dados relevantes para a aplicação
            .HasData(new[]{
                new Vacina(){
                    Id = 1,
                    Nome = "Gripe",
                    NumeroDoses = 1
                },
                new Vacina(){
                    Id = 2,
                    Nome = "Tétano",
                    NumeroDoses = 1
                }
            });

        // Clientes Vacinas
        modelBuilder.Entity<ClienteVacina>()
            .ToTable("ClientesVacinas");

        modelBuilder.Entity<ClienteVacina>()
            .HasKey(cv => new { cv.ClienteId, cv.VacinaId }); //chave primária que é composta por duas propriedades - valores que compoem a chave primaria

        modelBuilder.Entity<ClienteVacina>()
            .Property(cv => cv.DataAplicacao)
            .IsRequired();

        // Relacionamento de N pra N 

        //relação do cliente com o cliente vacina
        modelBuilder.Entity<ClienteVacina>()
            .HasOne<Cliente>(c => c.Cliente) //possui 1 do tipo cliente - oq representa o cliente dentro do cl
            .WithMany(c => c.Vacinas) //a lista de vacinas - dentro do cliente oq representa a lista de vacina
            .HasForeignKey(c => c.ClienteId) // cl tem fk
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ClienteVacina>()
            .HasOne<Vacina>(c => c.Vacina) //possui 1 do tipo vacina - oq representa vacina dentro do cl
            .WithMany()
            .HasForeignKey(c => c.VacinaId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
