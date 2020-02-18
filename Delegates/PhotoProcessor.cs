using System;

namespace Delegates {
    public class PhotoProcessor
    {
        //public delegate void PhotoFilterHandler(Photo photo);
        //public void Process(string path, PhotoFilterHandler filterHandler)

        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = new Photo();
            var filters = new PhotoFilters();

            filterHandler(photo);
            
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);
        }
    }
}