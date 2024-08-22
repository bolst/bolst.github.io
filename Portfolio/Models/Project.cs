namespace Portfolio.Models
{
    public record Project
    {
        public required string Name { get; init; }
        public required string Link { get; init; }
        public required string Background { get; init; }
        public required string Foreground { get; init; }
    }
}