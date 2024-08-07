//using System.Net.Http;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using System.Text.Json;

//namespace BlazorApp
//{
//    public class ApiService
//    {
//        private readonly HttpClient _httpClient;

//        public ApiService(HttpClient httpClient)
//        {
//            _httpClient = httpClient;
//        }

//        public async Task<List<JsonContent>> GetData()
//        {
//            var response = await _httpClient.GetAsync("https://magsapi.onrender.com/api/miles95");
//            response.EnsureSuccessStatusCode();

//            var content = await response.Content.ReadAsStringAsync();
//            return JsonSerializer.Deserialize<List<JsonContent>>(content);
//        }
//    }
//}
