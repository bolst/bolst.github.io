namespace Portfolio.Models;

public sealed record SocialMediaProfile(string Provider)
{
    public string? Href { get; init; }
    public string? Icon { get; init; }
    public string? Color { get; init; }
}

