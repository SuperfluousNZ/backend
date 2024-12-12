using Digraphy.Data;
using Digraphy.Interfaces;
using Digraphy.Mapper;
using Digraphy.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(MappingProfiles));
builder.Services.AddScoped<ITodoRepository, TodoRepository>();
builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.WebHost.UseUrls("http://localhost:5297");
builder.WebHost.ConfigureKestrel((context, opts) =>
{
    opts.Limits.MinRequestBodyDataRate = new MinDataRate(2, TimeSpan.FromSeconds(10));
});

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