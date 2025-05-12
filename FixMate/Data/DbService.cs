using FixMate.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FixMate.Data
{
    public class DbService
    {
        private ApplicationDbContext _context;

        public DbService(ApplicationDbContext context)
        {
            _context = context;
        }

        #region UserSubscriptions
        public async Task AddSubscriptionAsync(UserSubscription userSubscription)
        {
            _context.UserSubscriptions.Add(userSubscription);
            await _context.SaveChangesAsync();
        }

        public async Task<UserSubscription?> GetSubscriptionAsync(string userId)
        {
            return await _context.UserSubscriptions.FirstOrDefaultAsync(us => us.UserId == userId);
        }
        #endregion
    }
}
