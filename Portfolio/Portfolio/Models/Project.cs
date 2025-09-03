namespace Portfolio.Models;

public sealed record Project(string Name, string Description)
{
    public string? Url { get; init; }
    public string? RepoUrl { get; init; }
    public string? ImageUrl { get; init; }
    public string? Color { get; init; }
    public string? BackgroundColor { get; init; }
    public string ImageOffsetX { get; init; } = "center";
    public string ImageOffsetY { get; init; } = "center";
    public List<ProjectTech> TechStack { get; init; } = [];
}