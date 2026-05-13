using Avalonia.Controls;
using EdgeUI.Controls;
using EdgeUI.Design;

namespace EdgeUI.Windows;

/// <summary>
/// Base window for all EdgeUI applications.
/// </summary>
public class EdgeWindow : Window
{
    private EdgeTitleBar _titleBar;
    private Border _root;

    public EdgeWindow()
    {
        Width = 1024;
        Height = 576;

        Background = ThemeTokens.Colors.Surface;

        ExtendClientAreaToDecorationsHint = true;

        Build();
    }

    private void Build()
    {
        _titleBar = new EdgeTitleBar(this);

        _root = new Border
        {
            Background = ThemeTokens.Colors.Surface,
            Child = new StackPanel
            {
                Children =
                {
                    _titleBar
                }
            }
        };

        Content = _root;
    }
}
