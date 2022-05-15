﻿namespace MicaWPF.Models;
public class MicaEnabledWindow
{
    public Window Window { get; }
    public BackdropType BackdropType { get; }

    public MicaEnabledWindow(Window window, BackdropType backdropType)
    {
        Window = window;
        BackdropType = backdropType;
    }
}
