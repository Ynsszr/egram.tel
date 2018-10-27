﻿using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using PropertyChanged;

namespace Tel.Egram.Gui.Views.Settings.Connection
{
    [DoNotNotify]
    public class ProxyPopupControl : UserControl
    {   
        public ProxyPopupControl()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
