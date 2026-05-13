using Avalonia.Media;

namespace EdgeUI.Controls.EdgeButton;

public sealed class EdgeButtonStyle
{
    public IBrush Background { get; set; }
    public IBrush Foreground { get; set; }

    public IBrush HoverBackground { get; set; }
    public IBrush HoverForeground { get; set; }

    public IBrush PressBackground { get; set; }
    public IBrush PressForeground { get; set; }

    public EdgeButtonStyle(IBrush background, 
                           IBrush foreground,
                           IBrush hoverBackground,
                           IBrush hoverForeground,
                           IBrush pressBackground,
                           IBrush pressForeground)
    {
        Background = background;
        Foreground = foreground;
        HoverBackground = hoverBackground;
        HoverForeground = hoverForeground;
        PressBackground = pressBackground;
        PressForeground = pressForeground;
    }
}
