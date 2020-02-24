using System;

namespace Events {
    public class MessageService
    {
        public void OnVideoEncoded(object o, VideoEventArgs e)
        {
            Console.WriteLine("Message service: Sending a text message..." + e.Video.Title);
        }

        public void OnVideoEncoding(object o, EventArgs e)
        {
            Console.WriteLine("Message service: Encoding a video...");
        }
    }
}