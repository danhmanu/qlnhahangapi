using Microsoft.EntityFrameworkCore;
using QuanLyNhaHangAPI.Data;

var builder = WebApplication.CreateBuilder(args);

string WebApiDatabase = builder.Configuration.GetConnectionString("WebApiDatabase");
// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(context => context.UseMySQL(WebApiDatabase));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors();

var app = builder.Build();
app.UseCors(options =>
     options.WithOrigins("https://localhost:7192")
            .AllowAnyHeader()
            .AllowAnyMethod());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
