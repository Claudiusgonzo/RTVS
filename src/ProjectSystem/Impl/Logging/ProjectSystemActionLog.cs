﻿using System;
using Microsoft.R.Actions.Logging;

namespace Microsoft.VisualStudio.ProjectSystem.FileSystemMirroring.Logging {
    internal sealed class ProjectSystemActionLog : LinesLog {
        private static readonly Lazy<ProjectSystemActionLog> Instance = new Lazy<ProjectSystemActionLog>(
            () => new ProjectSystemActionLog(FileLogWriter.InTempFolder("Microsoft.VisualStudio.ProjectSystem.FileSystemMirroring")));

        public static IActionLog Default => Instance.Value;

        private ProjectSystemActionLog(IActionLogWriter logWriter) :
            base (logWriter){
        }
    }
}
