using System.Collections.Generic;

namespace Bounce.Framework.Tests {
    public class MockTask : ITask {
        public string FullName { get; set; }
        public string Command { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<ITaskParameter> Parameters { get; set; }
        public TaskParameters WasInvokedWithTaskParameters { get; private set; }
        public bool WasInvoked { get; private set; }

        public void Invoke(TaskParameters taskParameters) {
            WasInvoked = true;
            WasInvokedWithTaskParameters = taskParameters;
        }
    }
}