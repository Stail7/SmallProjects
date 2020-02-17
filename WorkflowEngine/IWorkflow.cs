using System.Collections.Generic;

namespace WorkflowEngine {
    public interface IWorkflow
    {
        void AddActivity(IActivity activity);
        void RemoveActivity(IActivity activity);
        IEnumerable<IActivity> GetActivity();
    }
}