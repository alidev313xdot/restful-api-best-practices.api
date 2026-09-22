using RestfulApiBestPractices.Api.DTOs;

namespace RestfulApiBestPractices.Api.Models
{
    // Product Entity 
    // entities carry the full state while request dtos carry part of the state with validating attributes 
    // and a response dto controls exactly what goes back 
    public record Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set;}
        public string? Category { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; 
        public DateTime UpdatedAt { get; set; }

        public ProductResponse ToResponse() => new(
             Id, Name, Description, Price, Stock, Category, CreatedAt, UpdatedAt
        );
    }
}
