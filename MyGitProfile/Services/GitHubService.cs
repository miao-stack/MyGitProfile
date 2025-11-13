using MyGitProfile.Models;
using Newtonsoft.Json;

namespace MyGitProfile.Services;

public class GitHubService
{
    private HttpClient _httpClient;
    public GitHubService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("MyGitProfileApp");
    }
    public async Task<GitHubUser?> GetUserAsync(string username)
    { 
        var userJson = await _httpClient.GetStringAsync($"https://api.github.com/users/{username}");
        var user= JsonConvert.DeserializeObject<GitHubUser>(userJson);
        var reposJson = await _httpClient.GetStringAsync($"https://api.github.com/users/{username}/repos");
        var repos = JsonConvert.DeserializeObject<List<Repository>>(reposJson);

        user.Repositories = repos;
        return user;
    }
        
}
