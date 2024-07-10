using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Task;

public class ApiRequest
{
    private readonly string _url;
    private readonly string _token;
    private readonly string _jsonBody;


    private readonly HttpClient _client = new HttpClient();

    public ApiRequest(string url, string token, string jsonBody)
    {
        _url = url;
        _token = token;
        _jsonBody = jsonBody;
    }

    public string SendPostRequest()
    {
        _client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer",_token);

        byte[] byteData = Encoding.UTF8.GetBytes(_jsonBody);

        ByteArrayContent content = new ByteArrayContent(byteData);
        content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

        HttpResponseMessage response = _client.PostAsync(_url, content).Result;

        if (!response.IsSuccessStatusCode)
            return "Ошибка при выполнении запроса!";

        return response.Content.ReadAsStringAsync().Result; 
    }
}
