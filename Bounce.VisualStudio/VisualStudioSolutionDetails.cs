﻿using System.Collections.Generic;

namespace Bounce.VisualStudio {
    public class VisualStudioSolutionDetails {
        public IEnumerable<VisualStudioCSharpProjectFileDetails> Projects { get; set; }
    }
}