using InfineonAssesment.Application.Service.Abstraction;
using InfineonAssesment.Application.Service.Implementation;
using InfineonAssesment.Infrastructure.Persistence;
using InfineonAssesment.Infrastructure.Repository.Abstraction;
using InfineonAssesment.Infrastructure.Repository.Implementation;
using InfineonAssesment.Shared.Dto.RequestDto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Mukoya.Application.HelperServices.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<InfineonContext>(option=>option.UseSqlServer(builder.Configuration.GetConnectionString("InfineonLocalDB")));
builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailConfiguration"));
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<TokenService>();

builder.Services.AddAuthorization();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();