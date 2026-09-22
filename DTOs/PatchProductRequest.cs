using System.ComponentModel.DataAnnotations;

namespace RestfulApiBestPractices.Api.DTOs
{
    // Create, Update mirros exactly same request, so does patch but with all fields nullables (partial updates) 
    public record PatchProductRequest(
        [property: Required, StringLength(200)] string? Name,
        [property: Required] string? Description,
        [property: Range(0.01, 1000000)] decimal? Price,
        [property: Range(0, int.MaxValue)] int? Stock,
        string? Category
        );
}
