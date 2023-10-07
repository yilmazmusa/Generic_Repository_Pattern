using Microsoft.EntityFrameworkCore;
using Generic_Repository_Pattern;
using Generic_Repository_Pattern.DB;
using Generic_Repository_Pattern.Relationals;
using Generic_Repository_Pattern.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBookRepository, BookRepository>(); //BookRepository yapýsýný kodumuzun içerisinde kullanabilmemiz için DI konteynerine eklememiz gerekiyor

builder.Services.AddScoped<IProductRepository, ProductRepository>();//ProductRepository yapýsýný kodumuzun içerisinde kullanabilmemiz için DI konteynerine eklememiz gerekiyor

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>)); //GenericRepository yapýsýný kodumuzun içerisinde kullanabilmemiz için DI konteynerine eklememiz gerekiyor


builder.Services.AddDbContext<LibraryDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SQLServer"));
});

var app = builder.Build();


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
