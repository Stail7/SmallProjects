using System;

namespace Events {
    public class MailService
    {
        // Event handler methods
        public void OnVideoEncoded(object o, VideoEventArgs e)
        {
            Console.WriteLine("Mail service: Sending an email..." + e.Video.Title);
        }

        public void OnVideoEncoding(object o, EventArgs e)
        {
            Console.WriteLine("Mail service: Encoding a video...");
        }
    }
}