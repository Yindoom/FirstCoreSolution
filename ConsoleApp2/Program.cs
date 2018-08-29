using System;
using System.Collections.Generic;
using TwoPersonTango.Core;
using TwoPersonTango.Core.ApplicationService;
using TwoPersonTango.Core.DomainService;
using TwoPersonTango.Core.Entity;
using TwoPersonTango.Infrastructure.Static.Data.Repositories;

namespace TwoPersonTango
{
    class Program
    {
        private static IVideoService _videoService;
        static void Main(string[] args)
        {
            _videoService = new VideoService();
            DisplayMain();
        }
        #region Program
        private static void DisplayMain()
        {
            Console.WriteLine("Choose action: \n\n1. List Videos \n2. Add Video \n3. Update Video \n4. Delete Video \n5. Exit");
            switch(Console.ReadLine().ToLower())
            {
                case "1":
                    Console.Clear();
                    ShowVideos();
                    Console.WriteLine("Press enter to return...");
                    Console.ReadLine();
                    DisplayMain();
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
                case "5":
                    break;
                default:
                    Console.WriteLine("This is not a  valid command. Please select a number between 1 and 5.");
                    DisplayMain();
                    break;
            }
        }

        private static void DeleteVideo()
        {
            Console.WriteLine("Write the name or id of the video you want deleted: ");
            ShowVideos();

            var deletion = Console.ReadLine();
            int result;
            Video deletedVid = null;
            foreach (var video in Videos)
            {
                if (video.Title.Equals(deletion) || int.TryParse(deletion, out result) && result == (video.Id + 1))
                {
                    deletedVid = video;
                }
                if(deletedVid != null)
                {
                    video.Id = video.Id - 1;
                }
            }
            if(deletedVid != null)
            {
                Videos.Remove(deletedVid);
                Console.WriteLine($"{deletedVid.Title} was removed. Press enter to go back");
            }
            else
            {
                Console.WriteLine("Could not find video. PRess enter to go back.");
            }
            Console.ReadLine();
            Console.Clear();
            DisplayMain();
        }

        private static void UpdateVideo()
        {
            ShowVideos();
            Console.WriteLine("Choose id of the video you want to edit: ");
            int id;
            Video update = null;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please write a number: ");
            }
            foreach (var video in Videos)
            {
                if(id == (video.Id + 1))
                { 
                    update = video;
                }
            }
            if(update != null)
            {
                Console.WriteLine($"You have chosen to update {update.Title}. Please write a new title: ");
                update.Title = Console.ReadLine();
                Console.WriteLine($"New title is {update.Title}. The current rating is: {update.Rating}.");
                Console.WriteLine("What will the new rating be?");
                int rating;
                while(!int.TryParse(Console.ReadLine(), out rating))
                {
                    Console.WriteLine("Please write a number.");
                }
                update.Rating = rating;
                Console.WriteLine($"{update.Title} has been updated.");
            }
            else
            {
                Console.WriteLine("Video not found.");
            }
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
            Console.Clear();
            DisplayMain();
        }

        private static void AddVideo()
        {
            Console.Clear();
            
            Console.WriteLine("Please write the title of the video you want to add: ");
            string title = Console.ReadLine();
            Console.WriteLine("Please type the rating, as a number: ");
            int rating;
            while(!int.TryParse(Console.ReadLine(), out rating))
            {
                Console.WriteLine("Please write a number");
            }
            Console.WriteLine($"{video.Title} has been added to the list. Press enter to exit...");
            Console.ReadLine();
            Console.Clear();
            DisplayMain();
        }

        private static void ShowVideos()
        {
            Console.WriteLine("Videos: ");
            foreach (var video in _videoService.GetVideos)
            {
                Console.WriteLine("{0} - {1} \nRating: {2}", video.Id+1, video.Title, video.Rating);
            }
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
#endregion