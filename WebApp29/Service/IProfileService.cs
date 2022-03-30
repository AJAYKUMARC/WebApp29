using WebApp29.Models;

namespace WebApp29.Service
{
    public interface IProfileService
    {
        IEnumerable<Profile> GetAllProfile();
        Profile GetProfile(int id);
    }
}