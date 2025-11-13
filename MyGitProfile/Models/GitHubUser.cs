using Newtonsoft.Json;

namespace MyGitProfile.Models;

public class GitHubUser
{
    [JsonProperty("login")]
    public string Login { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("avatar_url")]
    public string AvatarUrl { get; set; }
    [JsonProperty("bio")]
    public string Bio { get; set; }
    public List<Repository> Repositories { get; set; }

}
