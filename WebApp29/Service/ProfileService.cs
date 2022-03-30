using WebApp29.dbConetxt;
using WebApp29.Models;

namespace WebApp29.Service
{
    public class ProfileService : IProfileService
    {
        private readonly ApplicationDbContext context;
        public ProfileService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Profile> GetAllProfile()
        {
            return context.Profiles;
        }

        public Profile GetProfile(int id)
        {
            return context.Profiles.SingleOrDefault(x => x.Id == id);
        }
    }
}
