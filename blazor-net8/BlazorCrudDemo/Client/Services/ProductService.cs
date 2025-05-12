using Client.Models;
using System.Net.Http.Json;

namespace Client.Services
{
    public class ProductService
    {
        private readonly HttpClient _http;
        public ProductService(HttpClient http) => _http = http;

        public async Task<List<Product>> GetProductsAsync() =>
            await _http.GetFromJsonAsync<List<Product>>("https://localhost:5001/api/products") ?? [];

        public async Task<Product?> GetProductAsync(int id) =>
            await _http.GetFromJsonAsync<Product>($"https://localhost:5001/api/products/{id}");

        public async Task CreateProductAsync(Product product) =>
            await _http.PostAsJsonAsync("https://localhost:5001/api/products", product);

        public async Task UpdateProductAsync(Product product) =>
            await _http.PutAsJsonAsync($"https://localhost:5001/api/products/{product.Id}", product);

        public async Task DeleteProductAsync(int id) =>
            await _http.DeleteAsync($"https://localhost:5001/api/products/{id}");
    }

}
