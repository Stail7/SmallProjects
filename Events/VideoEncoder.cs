using System;
using System.Threading;

namespace Events 
{
    public class VideoEventArgs : EventArgs // class that contains parameters to send with event
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder 
    {
        // 1- Define a delegate.
        // 2- Define an event based on that delegate.
        // 3- Raise the event.

        // 1
        //public delegate void VideoEncodedEventHandler(object source, EventArgs args); // no parameters
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args); // with params defined in custom VideoEventArgs class
        // OR we may simply use .Net delegate: EventHandler
        // and skip this step:

        // 2
        //public event VideoEncodedEventHandler VideoEncoded;
        // with EventHandler:
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public event EventHandler VideoEncoding; // no parameters

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(1000);

            OnVideoEncoding(); // Raising the event
            OnVideoEncoded(video); // Raising the event with params
        }

        // 3
        protected virtual void OnVideoEncoded(Video video) // 3- Raise the event
        {
            //if(VideoEncoded != null) // check if there are subscribers (event handlers)
            //    VideoEncoded(this, EventArgs.Empty);
            // OR
            VideoEncoded?.Invoke(this, new VideoEventArgs() {Video = video});
        }

        protected virtual void OnVideoEncoding()
        {
            VideoEncoding?.Invoke(this, EventArgs.Empty);
        }
    }
}