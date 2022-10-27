using System;


namespace EFC1.Context;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContextFactory()
    {
    }

    public AppDbContext CreateDbContext(string[] args)
    {
        //Crear configuración mysql
        string url = "server=localhost;port=3306;user=root;password=Eg44640766;database=cursoNet";

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseMySql(url, ServerVersion.AutoDetect(url))
            .Options;
        
       return new AppDbContext(options);
        


    }
}

