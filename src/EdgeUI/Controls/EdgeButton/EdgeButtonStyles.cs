using Avalonia.Media;

namespace EdgeUI.Controls.EdgeButton;

public static class EdgeButtonStyles
{
    public static readonly EdgeButtonStyle Primary = new EdgeButtonStyle(
            new SolidColorBrush(Colors.White, 1),
            new SolidColorBrush(Colors.Black, 1),
            new SolidColorBrush(Colors.Transparent),
            new Avalonia.Thickness(0),
            new SolidColorBrush(Colors.White, 0.9),
            new SolidColorBrush(Colors.Black, 1),
            new SolidColorBrush(Colors.Transparent),
            new SolidColorBrush(Colors.White, 0.75),
            new SolidColorBrush(Colors.Black, 1),
            new SolidColorBrush(Colors.Transparent)
        );
    public static readonly EdgeButtonStyle Secondary = new EdgeButtonStyle(
            new SolidColorBrush(Colors.White, 0.05),
            new SolidColorBrush(Colors.White, 0.75),
            new SolidColorBrush(Colors.Transparent),
            new Avalonia.Thickness(0),
            new SolidColorBrush(Colors.White, 0.25),
            new SolidColorBrush(Colors.White, 1),
            new SolidColorBrush(Colors.Transparent),
            new SolidColorBrush(Colors.White, 0.5),
            new SolidColorBrush(Colors.White, 1),
            new SolidColorBrush(Colors.Transparent)
        );
    public static readonly EdgeButtonStyle Ghost = new EdgeButtonStyle(
            new SolidColorBrush(Colors.White, 0),
            new SolidColorBrush(Colors.White, 0.75),
            new SolidColorBrush(Colors.Transparent),
            new Avalonia.Thickness(0),
            new SolidColorBrush(Colors.White, 0.1),
            new SolidColorBrush(Colors.White, 1),
            new SolidColorBrush(Colors.Transparent),
            new SolidColorBrush(Colors.White, 0.25),
            new SolidColorBrush(Colors.White, 1),
            new SolidColorBrush(Colors.Transparent)
        );
    public static readonly EdgeButtonStyle Outline = new EdgeButtonStyle(
            new SolidColorBrush(Colors.White, 0),
            new SolidColorBrush(Colors.White, 0.75),
            new SolidColorBrush(Colors.White, 0.05),
            new Avalonia.Thickness(1),
            new SolidColorBrush(Colors.White, 0.05),
            new SolidColorBrush(Colors.White, 1),
            new SolidColorBrush(Colors.White, 0.25),
            new SolidColorBrush(Colors.White, 0.25),
            new SolidColorBrush(Colors.White, 1),
            new SolidColorBrush(Colors.White, 0.5)
        );
    public static readonly EdgeButtonStyle Destructive = new EdgeButtonStyle(
            new SolidColorBrush(Colors.Red, 0.25),
            new SolidColorBrush(Colors.White, 0.75),
            new SolidColorBrush(Colors.Transparent),
            new Avalonia.Thickness(0),
            new SolidColorBrush(Colors.Red, 0.5),
            new SolidColorBrush(Colors.White, 1),
            new SolidColorBrush(Colors.Transparent),
            new SolidColorBrush(Colors.Red, 0.75),
            new SolidColorBrush(Colors.White, 1),
            new SolidColorBrush(Colors.Transparent)
        );
}
