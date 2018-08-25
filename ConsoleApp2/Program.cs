using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        private static List<Video> Videos = new List<Video>();

        static void Main(string[] args)
        {
            SetVideos(Videos);
            DisplayMain();
        }

        private static void DisplayMain()
        {
            Console.WriteLine("Choose action: \n\n1. List Videos \n2. Add Video \n3. Update Video \n4. Delete Video");
            switch(Console.ReadLine().ToLower())
            {
                case "1":
                    ShowVideos();
                    break;
                case "2":
                    AddVideo();
                    break;
                case "3":
                    UpdateVideo();
                    break;
                case "4":
                    DeleteVideo();
                    break;
                default:
                    Console.WriteLine("This is not a  valid command. Please select a number between 1 and 4.");
                    break;
            }
        }

        private static void DeleteVideo()
        {
            throw new NotImplementedException();
        }

        private static void UpdateVideo()
        {
            throw new NotImplementedException();
        }

        private static void AddVideo()
        {
            throw new NotImplementedException();
        }

        private static void ShowVideos()
        {
            Console.Clear();
            Console.WriteLine("Videos: ");
            foreach (var video in Videos)
            {
                Console.WriteLine("{0} - {1} \nRating: {2}", video.Id+1, video.Title, video.Rating);
            }
            Console.WriteLine("Press Enter to go back...");
            Console.ReadLine();
            Console.Clear();
            DisplayMain();
        }

        private static void SetVideos(List<Video> videos)
        {
            Video video = new Video
            {
                Title = "Avengers go dusting",
                Rating = 10,
                Id = 0
            };
            videos.Add(video);
            Video video1 = new Video
            {
                Title = "Retards Push Buttons",
                Rating = 0,
                Id = 1
            };
            videos.Add(video1);
            Video video2 = new Video()
            {
                Title = "Fabio fucked up",
                Rating = 8,
                Id = 2
            };
            videos.Add(video2);
        }
    }
}
