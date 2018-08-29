using System;
using System.Collections.Generic;
using System.Text;
using TwoPersonTango.Core.Entity;

namespace TwoPersonTango.Core.ApplicationService
{
    public interface IVideoService
    {
        List<Video> GetVideos();

    }
}
