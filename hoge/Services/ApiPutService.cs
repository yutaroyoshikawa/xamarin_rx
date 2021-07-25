using System.Net.Http;
using System.Threading.Tasks;

namespace hoge.Services
{
    public class ApiPutService
    {
        
        public async Task ProblemLang(int id,string lang)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"),
                    $"https://localhost:5003/api/SkyApi/problem/lang/{id}/{lang}"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "*/*");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        // static async Task ProblemLang(int id,string lang)
        // {
        //     HttpResponseMessage response = await client.PutAsJsonAsync(
        //         $"https://localhost:5003/api/SkyApi/problem/lang/{id}/{lang}");
        // }
        
        public async Task ProblemKnowledgeField(int id,int knowledgeid)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"),
                    $"https://localhost:5003/api/SkyApi/problem/knowledgefieldid/{id}/{knowledgeid}"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "*/*");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        
        public async Task ProblemCategory(int id,int categoryid)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"),
                    $"https://localhost:5003/api/SkyApi/problem/categoryid/{id}/{categoryid}"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "*/*");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        
        public async Task ProblemBody(int id,string body)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"),
                    $"https://localhost:5003/api/SkyApi/problem/body/{id}/{body}"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "*/*");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        
        public async Task ProblemType(int id,string type)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"),
                    $"https://localhost:5003/api/SkyApi/problem/type/{id}/{type}"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "*/*");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        
        public async Task ProblemDisable(int id,int flag)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"),
                    $"https://localhost:5003/api/SkyApi/problem/disableflag/{id}/{flag}"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "*/*");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        
        public async Task ProblemLabel(int id,string label)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"),
                    $"https://localhost:5003/api/SkyApi/problem/label/{id}/{label}"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "*/*");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }        
        public async Task ProblemTranslate(int id,string translate)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"),
                    $"https://localhost:5003/api/SkyApi/problem/translate/{id}/{translate}"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "*/*");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }   
        
        public async Task ProblemOption(int id,int num, string option)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"),
                    $"https://localhost:5003/api/SkyApi/problem/option/{id}/{num}/{option}"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "*/*");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        
        public async Task ProblemAnswer(int problemid,int Num, string option)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"),
                    $"https://localhost:5003/api/SkyApi/problem/option/{problemid}/{Num}/{option}"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "*/*");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        
        public async Task ProblemAllDisable()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"),
                    "https://localhost:5003/api/SkyApi/problem/disable"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "*/*");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        
        public async Task ProblemAllEnable()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"),
                    "https://localhost:5003/api/SkyApi/problem/enable"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "*/*");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        
        public async Task Knowledge(int knowledgeid, string knowledge)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"),
                    $"https://localhost:5003/api/SkyApi/knowledgefield/{knowledgeid}/{knowledge}"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "*/*");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        
        public async Task Category(int categoryid, int knowledgeid, string name)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"),
                    $"https://localhost:5003/api/SkyApi/category/{categoryid}/{knowledgeid}/{name}"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "*/*");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        
    }
}