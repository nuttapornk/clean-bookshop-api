
using Application;
using Infrastructure;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using WebApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddWebApiServices();


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
else
{
    app.UseHsts();
}

using (var scope = app.Services.CreateScope())
{

	var service = scope.ServiceProvider;
	try
	{
		var context = service.GetRequiredService<AppDbContext>();
		context.Database.Migrate();
	}
	catch (Exception ex)
	{
		var logger = service.GetRequiredService<ILogger<Program>>();
		logger.LogError(ex, "An Error occurred sedding the Database.");
	}
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
