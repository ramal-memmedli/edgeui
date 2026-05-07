using Avalonia;
using Avalonia.Media;

namespace EdgeUI.Design;

public static class ThemeTokens
{
    public static class Colors
    {
        public static IBrush Primary = Brushes.Red;
        public static IBrush Secondary = Brushes.Gray;
        public static IBrush Danger = Brushes.IndianRed;
        public static IBrush Surface = Brushes.Black;
        public static IBrush Text = Brushes.White;
    }

    public static class Spacing
    {
        public static Thickness ButtonPadding = new(12, 6);
    }

    public static class Radius
    {
        public static CornerRadius None = new(0);
    }
}
