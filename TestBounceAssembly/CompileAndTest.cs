using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bounce.Framework;
using Bounce.Framework.VisualStudio;

namespace TestBounceAssembly
{
    public class CompileAndTest
    {
        [Task(Command = "compile:test", Description = "Comiples and tests the Bounce.sln solution")]
        public void Compile() {
            var vs = new VisualStudio(new Shell(Log.Default));
            var sln = vs.Solution("Bounce.sln");
            sln.Build();
        }
    }
}
