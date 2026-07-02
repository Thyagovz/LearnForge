using LearnForge.SharedContext;

namespace LearnForge.SubscriptionContext;

public class Plan : Base
{
    public required string Title { get; set; }
    public decimal Price { get; set; }
}