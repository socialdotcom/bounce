using System.Collections.Generic;
using System.Linq;

namespace Bounce.Framework {
    public class TaskRunner : ITaskRunner {
        public void RunTask(string taskName, TaskParameters taskParameters, IEnumerable<ITask> tasks) {
            
            var matchingTasksByCommand = tasks.Where(t => AllTaskCommands(t).Contains(taskName.ToLower())).ToArray();

            if (matchingTasksByCommand.Count() > 1) {
                throw new AmbiguousTaskNameException(taskName, matchingTasksByCommand);
            } else if (!matchingTasksByCommand.Any()) {
                throw new NoMatchingTaskException(taskName, tasks);
            } else {
                matchingTasksByCommand.Single().Invoke(taskParameters);
            }
        }

        public IEnumerable<string> AllTaskCommands(ITask task)
        {
            yield return task.Command.ToLower();
        }
    }
}