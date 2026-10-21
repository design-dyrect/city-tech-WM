namespace CityTech.Web.Models;

public class ServiceDetail
{
    public required string Slug { get; init; }
    public required string Title { get; init; }
    public string? Summary { get; init; }
    public required string Details { get; init; }
    public List<ServiceItem> Steps { get; init; } = new();
    public List<ServiceItem> Receives { get; init; } = new();
    public List<ServiceItem> Faqs { get; init; } = new();
}

public record ServiceItem(string Title, string Text);
