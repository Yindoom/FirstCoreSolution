using System;
using System.Collections.Generic;
using System.Text;
using TwoPersonTango.Core.Entity;

namespace TwoPersonTango.Core.DomainService
{
    public interface IVideoRepository
    {
        /* C
         * R
         * U
         * D*/
        Video AddVideo(Video video); //CREATE

        //READ
        Video GetVideoById(int id); //READ BY ID
        List<Video> GetAllVideos();

        //UPDATE
        Video UpdateVideo(Video video);

        //DELETE
        Video DeleteVideo(Video video);

    }
}
