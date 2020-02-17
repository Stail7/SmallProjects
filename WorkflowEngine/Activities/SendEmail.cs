using System;

namespace WorkflowEngine.Activities {
    public class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending a confirmation email.");
        }
    }
}