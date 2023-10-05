using Azure;
using System.Text.Json;

namespace LastSeenTest_goodGitStructure
{
    public interface IGetData
    {
        Response GetResponse(string url);
    }

    public class GetData : IGetData
    {
        public Response GetResponse(string url)
        {
            using var client = new HttpClient();
            using var result = client.Send(new HttpRequestMessage(HttpMethod.Get, url));
            using var reader = new StreamReader(result.Content.ReadAsStream());
            var stringContent = reader.ReadToEnd();
            return JsonSerializer.Deserialize<Response>(stringContent, new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            })!;
        }
    }


    class Program
    {
        static async Task Main(string[] args)
        {

            IGetData dataProvider = new GetData();

            string apiUrl = "https://sef.podkolzin.consulting/api/users/lastSeen";

            UserLoader userLoader = new UserLoader(dataProvider, apiUrl);

            User[] users = userLoader.GetAllUsers();

            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine(users.Length);
        }
    }
}
