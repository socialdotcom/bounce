using System;

namespace Bounce.Framework
{
    [AttributeUsage(AttributeTargets.Method)]
    public class TaskAttribute : Attribute
    {
        public string Command { get; set; }

        public string Description { get; set; }
    }
}
