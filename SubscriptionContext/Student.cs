using LearnForge.SubscriptionContext;

namespace LearnForge.SharedContext;

public class Student : Base
{
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required User User { get; set; }
    public required IList<Subscription> Subscriptions { get; set; }

    public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
}