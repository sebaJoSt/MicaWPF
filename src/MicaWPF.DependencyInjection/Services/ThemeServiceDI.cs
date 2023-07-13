﻿// <copyright file="ThemeServiceDI.cs" company="Zircon Technology">
// This software is distributed under the MIT license and its code is free of use.
// </copyright>

using System.Windows;
using MicaWPF.DependencyInjection.Options;
using MicaWPF.Events;
using MicaWPF.Models;
using MicaWPF.Services;

namespace MicaWPF.DependencyInjection.Services;

internal sealed class ThemeServiceDI : IThemeService
{
    private readonly MicaWPFOptions _options;
    private readonly IThemeService _themeService = ThemeService.Current;

    public ThemeServiceDI(MicaWPFOptions options)
    {
        _options = options;
        _ = _themeService.ChangeTheme(_options.Theme);
    }

    public IWeakEvent<WindowsTheme> ThemeChanged => _themeService.ThemeChanged;

    public List<BackdropEnabledWindow> BackdropEnabledWindows => _themeService.BackdropEnabledWindows;

    public WindowsTheme CurrentTheme => _themeService.CurrentTheme;

    public bool IsThemeAware => _themeService.IsThemeAware;

    public WindowsTheme ChangeTheme(WindowsTheme windowsTheme = WindowsTheme.Auto)
    {
        return _themeService.ChangeTheme(windowsTheme);
    }

    public void EnableBackdrop(Window window, BackdropType micaType = BackdropType.Mica)
    {
        _themeService.EnableBackdrop(window, micaType);
    }
}