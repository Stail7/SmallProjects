using WorkflowEngine.Activities;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.AddActivity(new VideoUploader());
            workflow.AddActivity(new CallWebService());
            workflow.AddActivity(new SendEmail());
            workflow.AddActivity(new ChangStatus());
            
            var workflowEngine = new WorkflowEngine(); 
            workflowEngine.Run(workflow);
        }
    }
}
