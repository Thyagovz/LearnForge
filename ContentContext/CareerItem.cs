namespace LearnForge.ContentContext;

public class CareerItem : Base
{
    public IList<String>? Notifications { get; set; }
    public CareerItem(int order, string? title, string description, Course? course)
    {
        if (course == null)
            throw new Exception("O curso não pode ser nulo");

        Order = order;
        Title = title;
        Description = description;
        Course = course;
    }

    public int Order { get; set; }
    public string? Title { get; set; }
    public string Description { get; set; } = string.Empty;
    public Course? Course { get; set; }
}

