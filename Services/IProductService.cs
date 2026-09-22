using RestfulApiBestPractices.Api.DTOs;
using RestfulApiBestPractices.Api.Models;

// Product Service 

namespace RestfulApiBestPractices.Api.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();
        //Task<(IEnumerable<Product> Items, int TotalCount)> GetPagedAsync(
        //    int page, int pageSize, string? category = null, string? sortby = "id", bool descending = false
        //    );
        Task<Product> GetByIdAsync(int id);
        //Task<Product> CreateAsync(CreateProductRequest request);
        //Task<Product?> UpdateAsync(UpdateProductRequest request); // why ? can return the changed the resources or not 
        //Task<Product?> PatchAsync(PatchProductRequest request);
        //Task<bool> DeleteAsync(int id);
    }
}
