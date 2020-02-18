using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var process = new PhotoProcessor();
            var filters = new PhotoFilters();
            
            //PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEye;

            process.Process("photo.jpg", filterHandler);
        }

        public static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye.");
        }
    }
}
