using System.Text;
using System.Text.Json;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            ApiRequest _request = new ApiRequest(ApiConfig.GetUrl,ApiConfig.GetToken,ApiConfig.GetJsonBody);

            try
            {
                string responseContent = _request.SendPostRequest();

                JsonDocument jsonDoc = JsonDocument.Parse(responseContent);
                JsonElement root = jsonDoc.RootElement;

                string? _nameValue = root
                                        .GetProperty("result")
                                        .GetProperty("result")
                                        .EnumerateArray()
                                        .First()
                                        .GetProperty("__name")
                                        .GetString();

                Console.WriteLine($"__name : {_nameValue}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
