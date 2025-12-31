using System.Reflection;
using MediatorDesignPattern.Example2.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Register Repository as Singleton (holds in-memory data)
builder.Services.AddSingleton<IOrderRepository, InMemoryOrderRepository>();

// Add MediatR to dependency injection container
// Automatically finds and registers all handlers in the assembly
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

// Add controllers
builder.Services.AddControllers();

// Swagger/OpenAPI configuration
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() 
    { 
        Title = "MediatR Design Pattern API", 
        Version = "v1",
        Description = "Mediator Pattern implementation using MediatR library"
    });
});

var app = builder.Build();

// Enable Swagger only in development environment
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "MediatR Design Pattern API v1");
        c.RoutePrefix = string.Empty; // Open Swagger at root
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// Startup information
Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║         MEDIATR DESIGN PATTERN - WEB API EXAMPLE              ║");
Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
Console.WriteLine();
Console.WriteLine("API Endpoints:");
Console.WriteLine("  GET    /api/orders           - Get all orders");
Console.WriteLine("  GET    /api/orders/{id}      - Get order by ID");
Console.WriteLine("  POST   /api/orders           - Create new order");
Console.WriteLine("  PATCH  /api/orders/{id}/status - Update order status");
Console.WriteLine();
Console.WriteLine("Swagger UI: https://localhost:{port}");
Console.WriteLine();
Console.WriteLine("MediatR Pattern Explanation:");
Console.WriteLine("- Controllers do not contain business logic");
Console.WriteLine("- All operations are sent to MediatR as Command/Query");
Console.WriteLine("- Handlers execute the business logic");
Console.WriteLine("- Supports CQRS (Command Query Responsibility Segregation) pattern");
Console.WriteLine();

app.Run();
