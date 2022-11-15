using ASPNET2.Reppositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "angular", policy =>
    {
        policy.WithOrigins("http//localhost:4200")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//CONFIGURAR CONEXION BASE DE DATOS MYSQL
var url = "server=localhost;port=3306;user=root;password=Eg44640766;database=grupo2_Db";
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseMySql(url, ServerVersion.AutoDetect(url))
);
// AÑADIR LOS REPOSITORIOS
builder.Services.AddScoped<IAddressRepository, AddressDbRepository>();
builder.Services.AddScoped<IBookRepository, BookDbRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryDbRepository>();
builder.Services.AddScoped<IAuthorRepository, AuthorDbRepository>();



var app = builder.Build();
app.UseCors("angular");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

