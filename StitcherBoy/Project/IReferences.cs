﻿// Stitcher Boy - a small library to help building post-build taks
// https://github.com/picrap/StitcherBoy
// MIT License - http://opensource.org/licenses/MIT
namespace StitcherBoy.Project
{
    using System.Collections.Generic;

    /// <summary>
    /// References interface
    /// </summary>
    public interface IReferences
    {
        /// <summary>
        /// Gets the references.
        /// </summary>
        /// <value>
        /// The references.
        /// </value>
        IEnumerable<AssemblyReference> References { get; }
    }
}
