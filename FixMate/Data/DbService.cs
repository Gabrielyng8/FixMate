using FixMate.Components.Pages;
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

        #region Tutorials
        public List<Tutorial> GetAllTutorials()
        {
            return new List<Tutorial>
            {
                new Tutorial
                {
                    Id = "1",
                    Title = "How to Check Tyre Pressure",
                    Description = "Learn how to check and inflate your tyres correctly to maintain safe driving conditions.",
                    PreviewImageUrl = "/images/tutorials/tyre-pressure.jpg",
                    Category = "Basic Checks",
                    SkillLevel = "Free"
                },

                new Tutorial
                {
                    Id = "2",
                    Title = "How to Jump-Start a Car",
                    Description = "Revive a dead car battery safely using jump leads or a battery pack.",
                    PreviewImageUrl = "/images/tutorials/jumpstart.jpg",
                    Category = "Emergency",
                    SkillLevel = "0"
                },

                new Tutorial
                {
                    Id = "3",
                    Title = "Replacing Wiper Blades",
                    Description = "Keep your vision clear in rain by replacing old or cracked wiper blades.",
                    PreviewImageUrl = "/images/tutorials/wipers.jpg",
                    Category = "Exterior",
                    SkillLevel = "0"
                },

                new Tutorial
                {
                    Id = "4",
                    Title = "How to Change Engine Oil",
                    Description = "Step-by-step guide to safely changing your car's engine oil and filter.",
                    PreviewImageUrl = "/images/tutorials/oil-change.jpg",
                    Category = "Engine",
                    SkillLevel = "1"
                },

                new Tutorial
                {
                    Id = "5",
                    Title = "Replacing Brake Pads",
                    Description = "Learn to replace worn brake pads — includes safety tips and tools needed.",
                    PreviewImageUrl = "/images/tutorials/brakes.jpg",
                    Category = "Brakes",
                    SkillLevel = "2"
                },

                new Tutorial
                {
                    Id = "6",
                    Title = "Diagnosing Dashboard Warning Lights",
                    Description = "Understand what those warning symbols mean and what to do next.",
                    PreviewImageUrl = "/images/tutorials/dashboard-lights.jpg",
                    Category = "Diagnostics",
                    SkillLevel = "2"
                },

                new Tutorial
                {
                    Id = "7",
                    Title = "Troubleshooting Engine Overheating",
                    Description = "Step-by-step to troubleshoot overheating and avoid engine damage.",
                    PreviewImageUrl = "/images/tutorials/overheat.jpg",
                    Category = "Engine",
                    SkillLevel = "3"
                },
            };
        }
        #endregion
    }

}
