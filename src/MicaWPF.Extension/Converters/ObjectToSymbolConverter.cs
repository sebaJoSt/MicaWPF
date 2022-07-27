﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using MicaWPF.Expansion.InternalExtensions;
using MicaWPF.Expansion.Symbols;

namespace MicaWPF.Expansion.Converters;

internal class ObjectToSymbolConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (value is FluentSystemIcons.Regular symbol)
            return symbol;

        if (value is FluentSystemIcons.Filled symbolFilled)
            return symbolFilled.Swap();

        return FluentSystemIcons.Regular.Empty;
    }

    /// <summary>
    /// Not Implemented.
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
