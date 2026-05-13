using Avalonia.Controls;
using EdgeUI.Controls;

namespace EdgeUI.Gallery.Shell;

public class GalleryMainWindow : Window
{
    public GalleryMainWindow()
    {
        Title = "EdgeUI Gallery";

        Content = new StackPanel
        {
            Children =
            {
                new EdgeButton
        {
            Text = "Default",
            Icon = Lucide.Avalonia.LucideIconKind.Album,
            Variant = EdgeButtonVariant.Default
        },
                new EdgeButton
        {
                    Text = "Primary",
                    Icon = Lucide.Avalonia.LucideIconKind.Airplay,
            
            
            Variant = EdgeButtonVariant.Primary

        },
                new EdgeButton
        {
                    Icon = Lucide.Avalonia.LucideIconKind.AlarmClock,

            Variant = EdgeButtonVariant.Primary

        }
            }
        };
    }
}
