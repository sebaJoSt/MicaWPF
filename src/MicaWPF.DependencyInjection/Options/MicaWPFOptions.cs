﻿using System.Windows.Media;

namespace MicaWPF.DependencyInjection.Options;
public sealed class MicaWPFOptions
{
    public bool IsTitleBarAndBorderAccentAware { get; set; } = true;
    public bool IsThemeAware { get; set; } = true;
    public bool UpdateAccentFromWindows { get; set; } = true;
    public WindowsTheme Theme { get; set; } = WindowsTheme.Auto;
    public Color AccentColor { get; set; } = default;
}
