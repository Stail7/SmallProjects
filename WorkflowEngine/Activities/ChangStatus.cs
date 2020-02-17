using System;

namespace WorkflowEngine.Activities {
    public class ChangStatus : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Changing status of encoding in the database.");
        }
    }
}