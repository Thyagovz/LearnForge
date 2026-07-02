using LearnForge.SharedContext;

namespace LearnForge.SubscriptionContext;

public class User : Base
{
    public required string Username { get; set; } 
    public required string Password { get; set; }
}