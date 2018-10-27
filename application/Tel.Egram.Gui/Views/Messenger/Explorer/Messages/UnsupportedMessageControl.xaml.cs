﻿using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using PropertyChanged;

namespace Tel.Egram.Gui.Views.Messenger.Explorer.Messages
{
    [DoNotNotify]
    public class UnsupportedMessageControl : UserControl
    {
        public UnsupportedMessageControl()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
