namespace Portfolio.Data.Models;

public sealed record SocialProfile(string Provider)
{
    public string? Href { get; init; }
    public string? Icon { get; init; }
    public string? Color { get; init; }
}

