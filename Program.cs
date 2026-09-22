using Microsoft.AspNetCore.Mvc;
using RestfulApiBestPractices.Api.DTOs;
using RestfulApiBestPractices.Api.Services;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddSingleton<IProductService, ProductService>();
builder.Services.AddOpenApi();
builder.Services.AddProblemDetails();

var app = builder.Build();

// Middleware
app.UseExceptionHandler();
app.MapOpenApi();
app.MapScalarApiReference();

// API Routes - Version 1
var api = app.MapGroup("/api/v1");

// GET /api/v1/products - Get all products (paginated)


// GET /api/v1/products/{id} - Get a product by ID
app.MapGet("/products/v1/{id:int}", async (int id, IProductService service) =>
{
    var product = await service.GetByIdAsync(id);
    return product is null ?
    Results.NotFound(new ProblemDetails
    {
        Status = StatusCodes.Status404NotFound,
        Title = "Product Not Found",
        Detail = $"Product with ID {id} was not found.",
        Instance = $"/api/v1/products/{id}"
    })
    : Results.Ok(product.ToResponse());
}
)
  .WithName("GetProductById")
  .WithSummary("Returns a product based on its unique identifier. Returns 404 if product not found")
  .Produces<ProductResponse>(StatusCodes.Status200OK)
  .Produces<ProductResponse>(StatusCodes.Status404NotFound)
  .WithTags("Products");


app.Run(); 