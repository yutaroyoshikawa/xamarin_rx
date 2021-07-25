using System.Net.Http;
using System.Threading.Tasks;

namespace hoge.Services
{
    public class ApiGetService
    {
        public async Task<string> ProblemAll()
        {
            using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
            {
                using (System.Net.Http.HttpResponseMessage response =
                    client.GetAsync("https://localhost:5003/api/SkyApi/problem/all").Result)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
            }
        }
        
        public async Task<string> ProblemOption(int id)
        {
            using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
            {
                using (System.Net.Http.HttpResponseMessage response =
                    client.GetAsync($"https://localhost:5003/api/SkyApi/problem/option/search/{id}").Result)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
            }
        }
        public async Task<string> ProblemAnswer(int problemId)
        {
            using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
            {
                using (System.Net.Http.HttpResponseMessage response =
                    client.GetAsync($"https://localhost:5003/api/SkyApi/problem/answer/search/{problemId}").Result)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
            }
        }
        public async Task<string> ProblemOne(int id)
        {
            using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
            {
                using (System.Net.Http.HttpResponseMessage response =
                    client.GetAsync($"https://localhost:5003/api/SkyApi/problem/search/{id}").Result)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
            }
        }
        
        public async Task<string> KnowledgefieldAll()
        {
            using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
            {
                using (System.Net.Http.HttpResponseMessage response =
                    client.GetAsync("https://localhost:5003/api/SkyApi/knowledgefield/all").Result)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
            }
        }
        public async Task<string> CategoryAll()
        {
            using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
            {
                using (System.Net.Http.HttpResponseMessage response =
                    client.GetAsync("https://localhost:5003/api/SkyApi/category/all").Result)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
            }
        }
    }
}