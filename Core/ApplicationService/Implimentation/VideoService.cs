using System.Collections.Generic;
using TwoPersonTango.Core.ApplicationService;
using TwoPersonTango.Core.DomainService;
using TwoPersonTango.Core.Entity;

namespace TwoPersonTango.Core
{
    public class VideoService : IVideoService
    {
        private IVideoRepository _videoRepo;
        public List<Video> GetVideos()
        {
            return _videoRepo.GetAllVideos();
        }
    }
}
