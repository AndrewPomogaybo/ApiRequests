namespace Task;

public class ApiConfig
{
    private static string _url = "https://zdkhiu5mp5dwa.elma365.ru/pub/v1/app/test_sreda/test_task/list";
    private static string _token = "6b2a6b4c-51c4-4beb-94b8-250d12d023b1";
    private static string _jsonBody = @"
                {
                    ""fileHash"": ""0190983f-d7be-7895-bc40-5f403f0bc287"",
                    ""format"": ""xlsx"",
                    ""withEventHandlers"": false
                }";


    public static string GetToken
    {
        get{return _token;}
    }

    public static string GetUrl
    {
        get{return _url;}
    }

    public static string GetJsonBody
    {
        get{return _jsonBody;}
    }
}
