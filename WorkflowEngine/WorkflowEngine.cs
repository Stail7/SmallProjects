using System;

namespace WorkflowEngine {
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (var activity in workflow.GetActivity())
            {
                try
                {
                    activity.Execute();
                }
                catch (Exception)
                {
                    Console.WriteLine("Exception in the " + typeof(IWorkflow));
                }
            }
        }
    }
}