namespace LearnForge.ContentContext;

public class CareerItem
{
    public int Ordem { get; set; }
    public string? Title { get; set; }
    public string Description { get; set; } = string.Empty;
    public Course? Course { get; set; }
}

