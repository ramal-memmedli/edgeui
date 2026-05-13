using Avalonia.Controls;
using EdgeUI.Design;
using EdgeUI.Windows;

namespace EdgeUI.Controls;

public class EdgeTitleBar : Grid
{
    private readonly EdgeWindow _window;

    public EdgeTitleBar(EdgeWindow window)
    {
        _window = window;

        Height = 48;
        Background = ThemeTokens.Colors.Surface;

        ColumnDefinitions = ColumnDefinitions.Parse("*, Auto");

        Build();
    }

    private void Build()
    {
        Children.Add(new TextBlock
        {
            Text = "EdgeUI Window",
            Foreground = ThemeTokens.Colors.Text,
            VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
            Margin = new Avalonia.Thickness(10, 0),
        });

        var actions = new WindowActions(_window);

        SetColumn(actions, 1);
        Children.Add(actions);

        EnableDrag();
    }

    private void EnableDrag()
    {
        PointerPressed += (_, e) =>
        {
            if (e.GetCurrentPoint(this).Properties.IsLeftButtonPressed)
            {
                _window.BeginMoveDrag(e);
            }
        };
    }
}
