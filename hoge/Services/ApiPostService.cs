using System.Net.Http;
using System.Threading.Tasks;
namespace SkyFront.Services
{
    public class ApiPostService
    {

        public async Task Problem(string lang, int knowledgeFieldID, int categoryID, string body, string type, string label)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), $"https://localhost:5003/api/SkyApi/problem/{lang}/{knowledgeFieldID}/{categoryID}/{body}/{type}/{label}"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "*/*");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        public async Task Answer(int problemid, int answernum, string answer)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), $"https://localhost:5003/api/SkyApi/problem/answer/{problemid}/{answernum}/{answer}"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "*/*");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        
        public async Task ProblemCopy(int id)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), $"https://localhost:5003/api/SkyApi/problem/copy/{id}"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "*/*");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        public async Task Option(int problemid, string option, int num)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), $"https://localhost:5003/api/SkyApi/problem/option/{problemid}/{option}/{num}"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "*/*");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        
        public async Task Knowledge(string knowledgefieldname)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), $"https://localhost:5003/api/SkyApi/knowledgefield/{knowledgefieldname}"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "*/*");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        
        public async Task Category(int knowledgefieldid, string categoryname)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), $"https://localhost:5003/api/SkyApi/category/{knowledgefieldid}/{categoryname}"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "*/*");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }
    }
}