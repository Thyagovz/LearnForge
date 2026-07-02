using LearnForge.ContentContext;

namespace LearnForge;

class Program
{
    static void Main(string[] args)
    {
        var course = new Course();
        course.Level = ContentContext.Enums.EContentLevel.Beginner;
        foreach (var item in course.Modules)
        {
            
        }
        
    }
}
