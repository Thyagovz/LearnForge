using LearnForge.NotificationContext;
using LearnForge.SubscriptionContext;

namespace LearnForge.SharedContext;

public class Student : Base
{
    public Student()
    {
        Subscriptions = new List<Subscription>();
    }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required User User { get; set; }
    public required IList<Subscription> Subscriptions { get; set; }

    public void CreateSubscription(Subscription subscription)
    {
        if (IsPremium)
        {
            AddNotification(new Notification("Premium", "O aluno já tem assinatura ativa"));
            return;
        }

        Subscriptions.Add(subscription);
    }
    public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
}