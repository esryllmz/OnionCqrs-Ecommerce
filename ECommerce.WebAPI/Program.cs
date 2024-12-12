using Core.CrossCuttingConcerns.Exceptions.Extensions;
using ECommerce.Application;
using ECommerce.Persistence;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddApplicationServiceDependencies();
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddHttpContextAccessor();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.ConfigureCustomExceptionMiddleware();

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
