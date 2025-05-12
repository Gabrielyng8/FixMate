using System.ComponentModel.DataAnnotations;

namespace FixMate.Data.Models
{
    public class UserSubscription
    {
        [Key]
        public string UserId { get; set; }
        public int SubscriptionId { get; set; }
    }
}
