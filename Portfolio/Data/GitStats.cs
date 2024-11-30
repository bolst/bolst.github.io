using Octokit;

namespace Portfolio.Data;

public class GitStats
{
    private readonly GitHubClient github;
    public GitStats()
    {
        github = new GitHubClient(new ProductHeaderValue("NBPortfolio", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version!.ToString()));
    }

    public async Task<int> GetTotalCommits()
    {
        try
        {
            var request = new SearchRepositoriesRequest()
            {
                User = "bolst",
            };

            var repos = await github.Search.SearchRepo(request);

            int totalCommits = 0;
            foreach (Repository repo in repos.Items)
            {
                var commits = await github.Repository.Commit.GetAll(repo.Id);
                totalCommits += commits.Count;
            }

            return totalCommits;
        }
        catch (Exception e)
        {
            return 534;
        }
    }
}
