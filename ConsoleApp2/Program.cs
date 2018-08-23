using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Videos = new List<Video>();
            SetVideos(Videos);
            foreach (var video in Videos)
            {
                Console.WriteLine(video.Title);
            }
            Console.ReadLine();
        }

        private static void SetVideos(List<Video> videos)
        {
            Video video = new Video
            {
                Title = "Avengers go dusting",
                Rating = 10
            };
            videos.Add(video);
            Video video1 = new Video
            {
                Title = "Retards Push Buttons aka programmers",
                Rating = 0
            };
            videos.Add(video1);
            Video video2 = new Video()
            {
                Title = "Fabio fucked up",
                Rating = 8
            };
            videos.Add(video2);
        }
    }
}
