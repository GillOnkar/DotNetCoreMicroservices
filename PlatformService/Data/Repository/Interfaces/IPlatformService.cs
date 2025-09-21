using PlatformService.Models;

namespace PlatformService.Data.Interfaces
{
    public interface IPlatformService
    {
        bool SaveChanges();
        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int platformId);
        void CreatePlatform();
    }
}
