﻿// <copyright file="FrameworkElementExtension.cs" company="Zircon Technology">
// This software is distributed under the MIT license and its code is free of use.
// </copyright>

namespace MicaWPF.Extensions;

/// <summary>
/// Extensions of <see cref="FrameworkElement"/>.
/// </summary>
public static class FrameworkElementExtension
{
    /// <summary>
    /// Refresh the style of the current element.
    /// </summary>
    public static void RefreshStyle(this FrameworkElement element)
    {
        lock (element)
        {
            var savedStyle = element.Style;
            element.Style = new();

            element.UpdateDefaultStyle();

            element.Style = savedStyle;
        }
    }
}
