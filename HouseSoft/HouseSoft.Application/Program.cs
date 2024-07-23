using Microsoft.EntityFrameworkCore;
using Teste_Playmove.Data.Context;
using Teste_Playmove.Domain.Interface;
using Teste_Playmove.Modal;
using Teste_Playmove.Service.Services;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddScoped<IFornecedores, FornecedoresService>();
builder.Services.AddScoped<IEmpresas, EmpresasService>();



builder.Configuration.AddJsonFile("appsettings.json");

// Configuracao do context db
builder.Services.AddDbContext<Context>(options =>
{
    options.UseMySQL(builder.Configuration.GetConnectionString("Server"));
});


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var corsSettings = builder.Configuration.GetSection("CorsSettings").Get<CorsSettings>();


builder.Services.AddCors(options => options.AddPolicy("ApiCorsPolicy", builder =>
{
    builder.AllowAnyHeader()
           .AllowCredentials()
           .AllowAnyMethod()
           .WithOrigins(corsSettings.AllowedOrigins);
}));

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
