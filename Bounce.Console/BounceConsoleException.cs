using System;
using System.IO;

namespace Bounce.Console {

    [Serializable]
    public abstract class BounceConsoleException : Exception {
        public abstract void Explain(TextWriter writer);
    }
}