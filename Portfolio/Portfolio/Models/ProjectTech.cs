namespace Portfolio.Models;

public sealed record ProjectTech
{
    public required string Title { get; init; }
    public required string Href { get; init; }
    public required string LogoUrl { get; init; }
    public required string Color { get; init; }
}

public sealed record ProjectTechs
{
    public static ProjectTech Blazor = new()
    {
        Title = "Blazor",
        Href = "https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor",
        LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7d/Microsoft_.NET_logo.svg/2048px-Microsoft_.NET_logo.svg.png",
        Color = "#6D47FF",
    };

    public static ProjectTech Postgres = new()
    {
        Title = "Postgres",
        Href = "https://www.postgresql.org/",
        LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/29/Postgresql_elephant.svg/250px-Postgresql_elephant.svg.png",
        Color = "#2577CF",
    };

    public static ProjectTech Stripe = new()
    {
        Title = "Stripe",
        Href = "https://www.stripe.com/",
        LogoUrl = "https://play-lh.googleusercontent.com/2PS6w7uBztfuMys5fgodNkTwTOE6bLVB2cJYbu5GHlARAK36FzO5bUfMDP9cEJk__cE",
        Color = "#625BF6",
    };

    public static ProjectTech N8N = new()
    {
        Title = "n8n",
        Href = "https://www.n8n.io/",
        LogoUrl = "https://pbs.twimg.com/profile_images/1536335358803251202/-gASF0c6_400x400.png",
        Color = "#DA5C76",
    };

    public static ProjectTech ThreeJS = new()
    {
        Title = "three.js",
        Href = "https://threejs.org/",
        LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Three.js_Icon.svg/250px-Three.js_Icon.svg.png",
        Color = "#469CED",
    };

    public static ProjectTech Qiskit = new()
    {
        Title = "Qiskit",
        Href = "https://www.ibm.com/quantum/qiskit",
        LogoUrl = "https://avatars.githubusercontent.com/u/30696987?s=280&v=4",
        Color = "#8043F3",
    };

    public static ProjectTech TrueNAS = new()
    {
        Title = "TrueNAS",
        Href = "https://www.truenas.com",
        LogoUrl = "https://www.truenas.com/wp-content/uploads/2025/05/truenas-logo-full-color-rgb.png",
        Color = "#4496D1",
    };

    public static ProjectTech Ollama = new()
    {
        Title = "Ollama",
        Href = "https://ollama.com/",
        LogoUrl = "https://ollama.com/public/ollama.png",
        Color = "#EEEEEE",
    };

    public static ProjectTech Jellyfin = new()
    {
        Title = "Jellyfin",
        Href = "https://jellyfin.org/",
        LogoUrl = "https://jellyfin.org/images/logo.svg",
        Color = "#7A70C4",
    };

    public static ProjectTech PiHole = new()
    {
        Title = "Pi-hole",
        Href = "https://pi-hole.net/",
        LogoUrl = "https://wp-cdn.pi-hole.net/wp-content/uploads/2023/05/pihole-logo-horizontal-white-e1683321640117.png",
        Color = "#FA3323",
    };

    public static ProjectTech Nginx = new()
    {
        Title = "Nginx",
        Href = "https://nginx.org/",
        LogoUrl = "https://nginx.org/img/nginx_logo_dark.png",
        Color = "#429445",
    };

    public static ProjectTech WireGuard = new()
    {
        Title = "WireGuard",
        Href = "https://wireguard.com/",
        LogoUrl = "https://www.wireguard.com/img/wireguard.svg",
        Color = "#EA3323",
    };
}