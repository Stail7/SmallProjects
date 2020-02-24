namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //publisher (event sender)
            var mailService = new MailService(); //subscriber (event handler)
            var messageService = new MessageService(); //another subscriber

            videoEncoder.VideoEncoding += mailService.OnVideoEncoding;
            videoEncoder.VideoEncoding += messageService.OnVideoEncoding;
            
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }   
    }
}
