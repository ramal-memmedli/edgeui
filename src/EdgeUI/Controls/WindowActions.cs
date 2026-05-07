using Avalonia.Controls;
using Avalonia.Media;
using EdgeUI.Design;
using EdgeUI.Utilities;
using EdgeUI.Windows;

namespace EdgeUI.Controls;

public class WindowActions : StackPanel
{
    private readonly EdgeWindow _window;

    public WindowActions(EdgeWindow window)
    {
        _window = window;

        Orientation = Avalonia.Layout.Orientation.Horizontal;

        Children.Add(CreateActionButton("—", Minimize));
        Children.Add(CreateActionButton("□", Maximize));
        Children.Add(CreateActionButton("X", Close));
    }

    private Button CreateActionButton(string text, Action action)
    {
        return new Button
        {
            Content = text,
            Width = 16,
            Height = 16,
            Background = Brushes.Transparent,
            Foreground = ThemeTokens.Colors.Text,
            BorderThickness = new Avalonia.Thickness(0),
            ClickMode = ClickMode.Release,
            Command = new RelayCommand(action)
        };
    }

    private void Minimize() => _window.WindowState = WindowState.Minimized;

    private void Maximize()
    {
        if (_window.WindowState == WindowState.Maximized)
            _window.WindowState = WindowState.Normal;
        else
            _window.WindowState = WindowState.Maximized;
    }

    private void Close() => _window.Close();
}
