using System;
using System.Collections.Generic;
using System.Text;
using TwoPersonTango.Core.DomainService;
using TwoPersonTango.Core.Entity;

namespace TwoPersonTango.Infrastructure.Static.Data.Repositories
{
    public class VideoRepository : IVideoRepository
    {
        private static List<Video> _videos = new List<Video>();

        public Video AddVideo(Video video)
        {
            video.Id = _videos.Count;
            _videos.Add(video);
            return video;
        }

        public List<Video> GetAllVideos()
        {
            return _videos;
        }

        public Video GetVideoById(int id)
        {
            foreach (var video in _videos)
            {
                if(video.Id == (id+1))
                {
                    return video;
                }
            }
            return null;
        }

        //REMOVE LATER APPARENTLY
        public Video UpdateVideo(Video video)
        {
            throw new NotImplementedException();
        }
        public Video DeleteVideo(Video video)
        {
            throw new NotImplementedException();
        }
    }
}
