using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Tp3_2375637.Data;
using Tp3_2375637.Models;
using Tp3_2375637.Services;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Tp3_2375637Context>(options =>
{
  options.UseSqlServer(builder.Configuration.GetConnectionString("Tp3_2375637Context") ?? throw new InvalidOperationException("Connection string 'Tp3_2375637Context' not found."));
  options.UseLazyLoadingProxies();
});
builder.Services.AddScoped<ScoresService>();

builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<Tp3_2375637Context>();

builder.Services.Configure<IdentityOptions>(options =>
{
  options.Password.RequireDigit = false;
  options.Password.RequiredLength = 5;
  options.Password.RequireLowercase = false;
  options.Password.RequireUppercase = false;
  options.Password.RequireNonAlphanumeric = false;
});

builder.Services.AddAuthentication(options =>
{
  options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
  options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
  options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
  options.SaveToken = true;
  options.RequireHttpsMetadata = false; // Lors du développement
  options.TokenValidationParameters = new TokenValidationParameters()
  {
    ValidateAudience = true,
    ValidateIssuer = true,
    ValidAudience = "http://localhost:4200", // Client => HTTP
    ValidIssuer = "https://localhost:7251",  // Serveur => HTTPS
    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Hala Madrid 15 Ldc Nizar le bizzare le lézard Nazim l'algérien Tomates"))
  };
});

builder.Services.AddCors(options =>
{
  options.AddPolicy("Allow all", policy =>
  {
    policy.AllowAnyOrigin();
    policy.AllowAnyMethod();
    policy.AllowAnyHeader();
  });
});

// Add services to the container.

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

app.UseCors("Allow all");

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
