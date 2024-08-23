using Octokit;

namespace Portfolio.Api
{
    public class GitStats
    {
        private static GitStats? instance = null;
        public static GitStats Instance()
        {
            if (instance is null) instance = new GitStats();
            return instance;
        }

        GitHubClient github;
        private GitStats()
        {
            github = new GitHubClient(new ProductHeaderValue("NBPortfolio", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version!.ToString()));
        }

        public async Task<int> TotalCommits()
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
            catch (Exception)
            {
                return 534;
            }
        }
    }
}
