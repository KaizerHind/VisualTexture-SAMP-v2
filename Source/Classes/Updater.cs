using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace VisualTexture_v2.Source.Classes
{
    public static class Updater
    {
        private static string REPOSITORY_URL = "https://api.github.com/repos/KaizerHind/VisualTexture-SAMP-v2/tags";

        public static async Task FetchUpdates()
        {

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("User-Agent", "UpdateFetchingService");

                    HttpResponseMessage response = await client.GetAsync(REPOSITORY_URL);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        var releases = JsonConvert.DeserializeObject<Release[]>(content);

                        if (releases != null && releases.Length > 0)
                        {
                            Release latestRelease = releases[releases.Length-1];
                            Console.WriteLine($"Latest Tag: {latestRelease.name}");

                            if(latestRelease.name != Definitions.release)
                            {

                            }
                        }
                        else
                        {
                            Console.WriteLine("No tags found.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"API request failed with status code: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }

    public class Release
    {
        public string name { get; set; }
    }
}
