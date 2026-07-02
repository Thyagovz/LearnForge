using LearnForge.SharedContext;

namespace LearnForge.SubscriptionContext;

public class Subscription : Base
{
    public required Plan Plan { get; set; }
    public DateTime? EndDate { get; set; }

    public bool IsInactive => EndDate <= DateTime.Now;
}