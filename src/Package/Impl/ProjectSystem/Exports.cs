﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.ComponentModel.Composition;
using Microsoft.Common.Core.IO;

namespace Microsoft.VisualStudio.R.Package.ProjectSystem {
    internal sealed class Export {

        [Export(typeof(IFileSystem))]
        private IFileSystem FileSystem { get; }

        public Export() {
            FileSystem = new FileSystem();
        }
    }
}