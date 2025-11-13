using Microsoft.AspNetCore.Mvc;

namespace MyGitProfile.Controllers;

public class ProfileController:Controller
{
    private readonly Services.GitHubService _gitHubService;
    public ProfileController(Services.GitHubService gitHubService)
    {
        _gitHubService = gitHubService;
    }

    public async Task<IActionResult> Index(string username= "miao-stack")
    {
        var user = await _gitHubService.GetUserAsync(username);
        return View(user);
    }
}
