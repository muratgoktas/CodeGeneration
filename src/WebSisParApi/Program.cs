using WebApi.Models.DapperContext;
using WebSisPar.Services;
using WebSisParApi.Repositories.AboutReposiory;
using WebSisParApi.Repositories.CategoryRepository;
using WebSisParApi.Repositories.ProductRepository;

var builder = WebApplication.CreateBuilder(args);


// ToDo: Add services to the container.
// ToDo: Context, ICategoryRepository isterse CategoryRepository ver ve New yap.
builder.Services.AddTransient<Context>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IProductRepository,ProductRepository>();
builder.Services.AddTransient<IAboutRepository,AboutRepository>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
