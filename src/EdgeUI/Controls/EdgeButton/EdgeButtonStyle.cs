using Avalonia;
using Avalonia.Media;

namespace EdgeUI.Controls.EdgeButton;

public sealed class EdgeButtonStyle
{
    public IBrush Background { get; set; }
    public IBrush Foreground { get; set; }
    public IBrush Border { get; set; }
    public Thickness BorderThickness { get; set; }

    public IBrush HoverBackground { get; set; }
    public IBrush HoverForeground { get; set; }
    public IBrush HoverBorder { get; set; }

    public IBrush PressBackground { get; set; }
    public IBrush PressForeground { get; set; }
    public IBrush PressBorder { get; set; }

    public EdgeButtonStyle(IBrush background, 
                           IBrush foreground,
                           IBrush border,
                           Thickness borderThickness,
                           IBrush hoverBackground,
                           IBrush hoverForeground,
                           IBrush hoverBorder,
                           IBrush pressBackground,
                           IBrush pressForeground,
                           IBrush pressBorder)
    {
        Background = background;
        Foreground = foreground;
        Border = border;
        HoverBackground = hoverBackground;
        HoverForeground = hoverForeground;
        HoverBorder = hoverBorder;
        PressBackground = pressBackground;
        PressForeground = pressForeground;
        PressBorder = pressBorder;
        BorderThickness = borderThickness;
    }
}
