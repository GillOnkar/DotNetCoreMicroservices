using PlatformService.Data.Interfaces;
using PlatformService.Models;

namespace PlatformService.Data.Repository.Implementation
{
    public class PlatformService : IPlatformService
    {
        private readonly AppDbContext _context;
        public PlatformService(AppDbContext context)
        {
            _context = context;
        }

        public void CreatePlatform(Platform platform)
        {
            if (platform == null)
            {
                throw new ArgumentNullException(nameof(platform));
            }

            _context.Platforms.Add(platform);
        }

        public Platform GetPlatformById(int platformId)
        {
            return _context.Platforms.FirstOrDefault(p => p.Id == platformId);
        }
        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _context.Platforms.ToList();
        }
        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public void CreatePlatform()
        {
            throw new NotImplementedException();
        }
    }
}