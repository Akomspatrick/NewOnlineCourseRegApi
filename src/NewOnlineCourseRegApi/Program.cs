using MediatR;
using Microsoft.Extensions.Configuration.Xml;
using NewOnlineCourseReg.Application;
using NewOnlineCourseRegApi.Extensions;
using NewOnlineCourseRegApi.Infrastructure;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();
// Add services to the container.
builder.Services.AddMediatR(Assembly.GetExecutingAssembly())

.AddApplication()
.AddRepositories().AddUnitOfWork().AddDatabase(configuration)

//.AddBusinessServices()
.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
app.UseExceptionHandler("/error");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
