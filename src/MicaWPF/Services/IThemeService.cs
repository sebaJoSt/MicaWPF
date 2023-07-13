﻿// <copyright file="IThemeService.cs" company="Zircon Technology">
// This software is distributed under the MIT license and its code is free of use.
// </copyright>

using MicaWPF.Events;

namespace MicaWPF.Services;

/// <summary>
/// Service that manages the theme of the application.
/// </summary>
public interface IThemeService
{
    /// <summary>
    /// Gets contains information about the current theme.
    /// </summary>
    WindowsTheme CurrentTheme { get; }

    /// <summary>
    /// Gets a value indicating whether indicates if the service is aware of windows theme changes.
    /// </summary>
    bool IsThemeAware { get; }

    /// <summary>
    /// Gets list of windows that have Mica enabled.
    /// </summary>
    List<BackdropEnabledWindow> BackdropEnabledWindows { get; }

    /// <summary>
    /// Gets event that is raised when the theme is changed.
    /// </summary>
    IWeakEvent<WindowsTheme> ThemeChanged { get; }

    /// <summary>
    /// Changes the current theme.
    /// </summary>
    /// <param name="windowsTheme">The theme to switch to. Default is `WindowsTheme.Auto`.</param>
    /// <returns>The newly set theme.</returns>
    WindowsTheme ChangeTheme(WindowsTheme windowsTheme = WindowsTheme.Auto);

    /// <summary>
    /// Enables the backdrop on the given window with the specified type.
    /// </summary>
    /// <param name="window">The window to enable the backdrop on.</param>
    /// <param name="micaType">The type of backdrop to enable. Default is `BackdropType.Mica`.</param>
    void EnableBackdrop(Window window, BackdropType micaType = BackdropType.Mica);
}