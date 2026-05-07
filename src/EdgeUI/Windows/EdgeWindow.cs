using Avalonia.Controls;
using EdgeUI.Controls;
using EdgeUI.Design;

namespace EdgeUI.Windows;

/// <summary>
/// Base window for all EdgeUI applications.
/// </summary>
public class EdgeWindow : Window
{
    private TitleBar _titleBar;
    private Border _root;

    public EdgeWindow()
    {
        Width = 1024;
        Height = 576;

        Background = ThemeTokens.Colors.Surface;

        WindowDecorations = WindowDecorations.None;

        Build();
    }

    private void Build()
    {
        _titleBar = new TitleBar(this);

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
