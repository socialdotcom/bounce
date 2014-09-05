using System.Collections.Generic;
using NUnit.Framework;

namespace Bounce.Framework.Tests {
    [TestFixture]
    public class TaskRunnerTests {

        [Test]
        public void CanInvokeTaskByCommand()
        {
            var task = new MockTask { Command = "db:migrate" };
            var runner = new TaskRunner();

            AssertTaskIsInvokedWithName("db:migrate", runner, task);
        }

        [Test]
        public void TaskCanBeInvokedWithNameInsensitiveOfCase() {
            var task = new MockTask {Command = "Db:MigRate"};
            var runner = new TaskRunner();

            AssertTaskIsInvokedWithName("db:migrate", runner, task);
        }

        private static void AssertTaskIsInvokedWithName(string taskName, ITaskRunner runner, MockTask task) {
            runner.RunTask(taskName, new TaskParameters(new Dictionary<string, string>()), new[] {task});
            Assert.That(task.WasInvoked, Is.True);
        }
    }
}