using PhotoConsoleLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoConsoleLibrary.Screen
{
    public class PhotoView
    {
        public void PrintView(List<PhotoApiResponse>? photoApiResponses)
        {
            if(photoApiResponses == null)
            {
                Console.WriteLine("No photos in album.");
                return;
            }

            foreach(var response in photoApiResponses)
            {
                Console.WriteLine($"{response.Id}");

                Console.WriteLine($"TITLE: {response.Title}");
                Console.WriteLine($"ALBUM ID:{response.AlbumId}");
                Console.WriteLine($"URL: {response.Url}");
                Console.WriteLine($"THUMBNAIL: {response.ThumbnailUrl}");
                Console.WriteLine("");
            }
        }
    }
}
