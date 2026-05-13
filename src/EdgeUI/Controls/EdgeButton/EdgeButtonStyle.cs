using Avalonia.Media;

namespace EdgeUI.Controls.EdgeButton;

public sealed class EdgeButtonStyle
{
    public IBrush Background;
    public IBrush Foreground;

    public IBrush HoverBackground;
    public IBrush HoverForeground;

    public EdgeButtonStyle(IBrush background, 
                           IBrush foreground,
                           IBrush hoverBackground,
                           IBrush hoverForeground)
    {
        Background = background;
        Foreground = foreground;
        HoverBackground = hoverBackground;
        HoverForeground = hoverForeground;
    }
}
