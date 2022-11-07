

namespace ASPNET2.Db;

public class AppDbContext : DbContext 
{

   
    //Atributos
    public DbSet<Book>Books { get; set; } //Agregar un DbSet por cada clase modelo que tengamos
    public DbSet<Author> Authors { get; set; } //Agregar un DbSet por cada clase modelo que tengamos
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Category> Categories { get; set; }

    //Constructores
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    //Configurar determinadas columnas a nivel global
    /*
    protected override void ConfigureConventions(ModelConfigurationBuilder confBuilder)
    {
        confBuilder.Properties<string>().HaveMaxLength(100);
    }
    */
}

