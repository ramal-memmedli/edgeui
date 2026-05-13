using Avalonia.Media;

namespace EdgeUI.Controls.EdgeButton;

public static class EdgeButtonStyles
{
    public static readonly EdgeButtonStyle Primary = new EdgeButtonStyle(
            new SolidColorBrush(Colors.White, 1),
            new SolidColorBrush(Colors.Black, 1),
            new SolidColorBrush(Colors.White, 0.9),
            new SolidColorBrush(Colors.Black, 1)
        );
}
