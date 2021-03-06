// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using windows = Windows;

namespace Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT
{
    /// <summary>
    /// <see cref="windows.UI.Xaml.Media.Projection"/>
    /// </summary>
    public class Projection
    {
        private windows.UI.Xaml.Media.Projection UwpInstance { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Projection"/> class, a
        /// Wpf-enabled wrapper for <see cref="windows.UI.Xaml.Media.Projection"/>
        /// </summary>
        public Projection(windows.UI.Xaml.Media.Projection instance)
        {
            this.UwpInstance = instance;
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="windows.UI.Xaml.Media.Projection"/> to <see cref="Projection"/>.
        /// </summary>
        /// <param name="args">The <see cref="windows.UI.Xaml.Media.Projection"/> instance containing the event data.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Projection(
            windows.UI.Xaml.Media.Projection args)
        {
            return FromProjection(args);
        }

        /// <summary>
        /// Creates a <see cref="Projection"/> from <see cref="windows.UI.Xaml.Media.Projection"/>.
        /// </summary>
        /// <param name="args">The <see cref="windows.UI.Xaml.Media.Projection"/> instance containing the event data.</param>
        /// <returns><see cref="Projection"/></returns>
        public static Projection FromProjection(windows.UI.Xaml.Media.Projection args)
        {
            return new Projection(args);
        }
    }
}