using RestfulApiBestPractices.Api.DTOs;
using RestfulApiBestPractices.Api.Models;
using RestfulApiBestPractices.Api.Services;

public class ProductService : IProductService
{
    private static readonly List<Product> _products =
      [
            new Product { Id = 1, Name = "Laptop", Description = "High-performance laptop for developers", Price = 999.99m, Stock = 50, Category = "Electronics" },
            new Product { Id = 2, Name = "Wireless Mouse", Description = "Ergonomic wireless mouse with precision tracking", Price = 29.99m, Stock = 200, Category = "Electronics" },
            new Product { Id = 3, Name = "Mechanical Keyboard", Description = "RGB mechanical keyboard with Cherry MX switches", Price = 149.99m, Stock = 100, Category = "Electronics" },
            new Product { Id = 4, Name = "4K Monitor", Description = "27-inch 4K UHD monitor with HDR support", Price = 449.99m, Stock = 30, Category = "Electronics" },
            new Product { Id = 5, Name = "USB-C Hub", Description = "7-in-1 USB-C hub with HDMI and SD card reader", Price = 49.99m, Stock = 150, Category = "Accessories" },
            new Product { Id = 6, Name = "Webcam HD", Description = "1080p HD webcam with built-in microphone", Price = 79.99m, Stock = 80, Category = "Electronics" },
            new Product { Id = 7, Name = "Noise-Cancelling Headphones", Description = "Premium wireless headphones with ANC", Price = 299.99m, Stock = 45, Category = "Audio" },
            new Product { Id = 8, Name = "Standing Desk", Description = "Electric height-adjustable standing desk", Price = 599.99m, Stock = 20, Category = "Furniture" },
            new Product { Id = 9, Name = "Ergonomic Chair", Description = "Mesh ergonomic office chair with lumbar support", Price = 399.99m, Stock = 35, Category = "Furniture" },
            new Product { Id = 10, Name = "Desk Lamp", Description = "LED desk lamp with adjustable color temperature", Price = 39.99m, Stock = 120, Category = "Accessories" }
      ];

    private static int _nextid = 11;
    private static readonly Lock _lock = new();

    // Defining methods 
    public Task<IEnumerable<Product>> GetAllAsync() => Task.FromResult<IEnumerable<Product>>(_products);
    public Task<Product> GetByIdAsync(int id) => Task.FromResult(_products.FirstOrDefault(p => p.Id == id)); 
    
} 