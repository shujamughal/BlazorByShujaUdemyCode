using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SimpleShop.Client.Services
{
    public class OrderService
    {
        private readonly HttpClient httpClient;
        public OrderService(HttpClient httpClient)
        => this.httpClient = httpClient;
        public async Task<string> PlaceOrder()
        {
            string status = await this.httpClient.GetFromJsonAsync<string>
              ("/api/Order");
            return status;
        }
    }
}
