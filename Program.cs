var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    // Optionally, specify the route for the Swagger UI
    c.RoutePrefix = string.Empty;  // Swagger will be available at the root (e.g., /swagger)
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
