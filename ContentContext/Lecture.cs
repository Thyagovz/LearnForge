using LearnForge.ContentContext.Enums;
using LearnForge.SharedContext;

namespace LearnForge.ContentContext;
public class Lecture : Base
{
    public int Order { get; set; }
    public string Title { get; set; } = string.Empty;
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }
}