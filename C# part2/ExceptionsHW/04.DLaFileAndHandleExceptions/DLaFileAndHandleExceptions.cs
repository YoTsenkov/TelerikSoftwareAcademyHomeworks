using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

class DLaFileAndHandleExceptions
{
    static void Main()
    {
        string imageUrl = "http://www.wallpapers.com/media/6b79cacd-53b8-4d91-9314-189b35fea4be/";
        string fileName = "cottageawp_400x250.jpg";
        string fullPath = imageUrl + fileName;
        WebClient downloader = new WebClient();
        using (downloader)
        {
            try
            {
                downloader.DownloadFile(fullPath, fileName);                
            }
            catch (Exception ex)
            {
                if (ex is ArgumentNullException)
                {
                    Console.WriteLine("You have entered invalid url or storage file name.");
                }
                else if (ex is WebException)
                {
                    Console.WriteLine("Can't access the file due to internet issues. Check your internet connection.");
                }
                else if (ex is NotSupportedException)
                {
                    Console.WriteLine("Action denied. You are most likely trying to write to a file that does not support the required functionality.");
                }
            }
        }
    }
}