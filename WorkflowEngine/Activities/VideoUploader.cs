using System;

namespace WorkflowEngine.Activities {
    public class VideoUploader : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading video to a cloud storage.");
        }
    }
}