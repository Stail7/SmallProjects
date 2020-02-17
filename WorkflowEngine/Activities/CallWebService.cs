using System;

namespace WorkflowEngine.Activities {
    public class CallWebService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Calling third-party video encoding service.");
        }
    }
}