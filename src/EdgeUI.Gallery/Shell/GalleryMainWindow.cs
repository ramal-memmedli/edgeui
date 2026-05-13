using Avalonia.Controls;
using Avalonia.Media;
using EdgeUI.Controls.EdgeButton;

namespace EdgeUI.Gallery.Shell;

public class GalleryMainWindow : Window
{
    public GalleryMainWindow()
    {
        Title = "EdgeUI Gallery";

        Background = Brushes.Black;

        Content = new StackPanel
        {
            HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
            VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
            Orientation = Avalonia.Layout.Orientation.Horizontal,
            Spacing = 25,
            Children =
            {
                new EdgeButton
                {
                    Text = "Primary",
                    Icon = Lucide.Avalonia.LucideIconKind.Coffee,
                    Variant = EdgeButtonVariant.Primary
                },
                new EdgeButton
                {
                    Text = "Secondary",
                    Icon = Lucide.Avalonia.LucideIconKind.Airplay,
                    Variant = EdgeButtonVariant.Secondary
                },
                new EdgeButton
                {
                    Text = "Ghost",
                    Icon = Lucide.Avalonia.LucideIconKind.AlarmClock,
                    Variant = EdgeButtonVariant.Ghost
                },
                new EdgeButton
                {
                    Text = "Outline",
                    Icon = Lucide.Avalonia.LucideIconKind.AlignStartVertical,
                    Variant = EdgeButtonVariant.Outline
                },
                new EdgeButton
                {
                    Text = "Destructive",
                    Icon = Lucide.Avalonia.LucideIconKind.Recycle,
                    Variant = EdgeButtonVariant.Destructive
                }
            }
        };
    }
}
