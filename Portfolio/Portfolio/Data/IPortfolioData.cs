namespace Portfolio.Data;
using Techs = Models.ProjectTechs;
using MudBlazor;

public interface IPortfolioData
{
    Task<IEnumerable<Models.SocialProfile>> GetSocialsAsync();
    Task<IEnumerable<Models.Project>> GetProjectsAsync();
}

public class PortfolioData : IPortfolioData
{
    public Task<IEnumerable<Models.SocialProfile>> GetSocialsAsync()
    { 
        IEnumerable<Models.SocialProfile> profiles =
        [
            new ("CV")
            {
                Href = "./docs/cv.pdf",
                Icon = Icons.Material.Rounded.Article,
                Color = "#BABABA",
            },
            new("GitHub")
            {
                Href = "https://github.com/bolst",
                Icon = Icons.Custom.Brands.GitHub,
                Color = "#FCFCFC"
            },
            new("LinkedIn")
            {
                Href = "https://www.linkedin.com/in/nicbolt",
                Icon = Icons.Custom.Brands.LinkedIn,
                Color = "#0072B1"
            },
        ];
        return Task.FromResult(profiles);
    }

    public Task<IEnumerable<Models.Project>> GetProjectsAsync()
    {
        IEnumerable<Models.Project> projects = 
        [
            new("Bolton Cup", "Website, scoresheet app, and draft app for the annual Bolton Cup hockey tournament involving 6 teams, nearly 100 players, and $1000+ worth of prizes")
            {
                Url = "https://boltoncup.ca",
                RepoUrl = "https://github.com/bolst/BoltonCup",
                ImageUrl = "https://iiedqecnfyojvubvugmy.supabase.co/storage/v1/object/public/images/web-home.jpg",
                ImageOffsetY = "25%",
                TechStack = [Techs.Blazor, Techs.Postgres, Techs.Stripe, Techs.N8N, Techs.Docker]
            },
            new("Home Lab", "My setup to run my own local services such as custom DNS and local AI agents")
            {
                ImageUrl = "https://linuxhandbook.com/content/images/2021/11/homelab-setup.webp",
                TechStack = [Techs.TrueNAS, Techs.Docker, Techs.Ollama, Techs.PiHole, Techs.Nginx, Techs.WireGuard],
                ImageOffsetY = "65%"
            },
            new("Emergency Dispatch Simulator", "Submission for the Higgs Hackathon, hosted by Boson AI and MScAC (placed top 6 out of 80+ teams)")
            {
                Url = "/?project=eds",
                RepoUrl = "https://github.com/RishiDinesh/emergency-dispatch-simulator",
                ImageUrl = "https://media.istockphoto.com/id/1319258476/photo/female-air-traffic-controller-with-headset-talk-on-a-call-in-airport-tower-office-room-is.jpg?s=612x612&w=0&k=20&c=OQOVKLkclxoTAIoE_JFa404rAJ0jsNZxIONng6J4Jgg=",
                TechStack = [Techs.HiggsV2, Techs.OpenAiApi, Techs.FastAPI, Techs.Blazor, Techs.Docker],
                Target = null
            },
            new("Exo Explorer", "Submission for 2024 NASA Space Apps Challenge")
            {
                Url = "https://bolst.github.io/ExoExplorer/",
                RepoUrl = "https://github.com/bolst/ExoExplorer",
                ImageUrl = "https://news.stanford.edu/__data/assets/image/0033/86955/Exoplanets.jpeg",
                TechStack = [Techs.ThreeJS]
            },        
            new("Classical Shor", "A classical implementation of Shor's Algorithm, showing how (large) integers can be factored in polynomial time")
            {
                Url = "https://github.com/bolst/classical-shor",
                RepoUrl = "https://github.com/bolst/classical-shor",
                ImageUrl = "https://bernardmarr.com/wp-content/uploads/2021/08/The-Future-of-Quantum-Computing.jpg",
                TechStack = [Techs.Qiskit],
            },
        ];
        return Task.FromResult(projects);
    }
}