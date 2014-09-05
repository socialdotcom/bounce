using System.Collections.Generic;

namespace Bounce.Framework {
    public interface ITask {
        string FullName { get; }
        string Command { get; }
        string Description { get; }
        IEnumerable<ITaskParameter> Parameters { get; }
        void Invoke(TaskParameters taskParameters);
    }
}