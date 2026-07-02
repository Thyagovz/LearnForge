using LearnForge.SharedContext;

namespace LearnForge.ContentContext;

public class Module : Base
{
    public Module()
    {
        Lectures = new List<Lecture>();
    }
    public int Order { get; set; }
    public string Title { get; set; } = string.Empty;
    public IList<Lecture> Lectures { get; set; }
}