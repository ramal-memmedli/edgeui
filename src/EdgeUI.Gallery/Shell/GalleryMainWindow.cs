using Avalonia.Controls;
using Avalonia.Media;
using EdgeUI.Controls.EdgeButton;
using Lucide.Avalonia;

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
            Orientation = Avalonia.Layout.Orientation.Vertical,
            Spacing = 25,
            Children =
            {
                new StackPanel
                {
                    Orientation = Avalonia.Layout.Orientation.Vertical,
                    Spacing = 8,
                    Children =
                    {
                        new TextBlock
                        {
                            Text = "Primary",
                            Foreground = Brushes.White
                        },
                        new StackPanel {
                            Orientation = Avalonia.Layout.Orientation.Horizontal,
                            Spacing = 8,
                            Children =
                            {
                                new EdgeButton
                                {
                                    Text = "Apply",
                                    Variant = EdgeButtonVariant.Primary
                                },
                                new EdgeButton
                                {
                                    Icon = LucideIconKind.Check,
                                    Variant = EdgeButtonVariant.Primary
                                },
                                new EdgeButton
                                {
                                    Text = "Apply",
                                    Icon = LucideIconKind.Check,
                                    Variant = EdgeButtonVariant.Primary
                                },
                                new EdgeButton
                                {
                                    Text = "Apply",
                                    Variant = EdgeButtonVariant.Primary,
                                    IsEnabled = false
                                },
                            }
                        }
                    }
                },
                new StackPanel
                {
                    Orientation = Avalonia.Layout.Orientation.Vertical,
                    Spacing = 8,
                    Children =
                    {
                        new TextBlock
                        {
                            Text = "Secondary",
                            Foreground = Brushes.White
                        },
                        new StackPanel {
                            Orientation = Avalonia.Layout.Orientation.Horizontal,
                            Spacing = 8,
                            Children =
                            {
                                new EdgeButton
                                {
                                    Text = "Back",
                                    Variant = EdgeButtonVariant.Secondary
                                },
                                new EdgeButton
                                {
                                    Icon = LucideIconKind.ChevronLeft,
                                    Variant = EdgeButtonVariant.Secondary
                                },
                                new EdgeButton
                                {
                                    Text = "Back",
                                    Icon = LucideIconKind.ChevronLeft,
                                    Variant = EdgeButtonVariant.Secondary
                                },
                                new EdgeButton
                                {
                                    Text = "Back",
                                    Variant = EdgeButtonVariant.Secondary,
                                    IsEnabled = false
                                },
                            }
                        }
                    }
                },
                new StackPanel
                {
                    Orientation = Avalonia.Layout.Orientation.Vertical,
                    Spacing = 8,
                    Children =
                    {
                        new TextBlock
                        {
                            Text = "Ghost",
                            Foreground = Brushes.White
                        },
                        new StackPanel {
                            Orientation = Avalonia.Layout.Orientation.Horizontal,
                            Spacing = 8,
                            Children =
                            {
                                new EdgeButton
                                {
                                    Text = "Dismiss",
                                    Variant = EdgeButtonVariant.Ghost
                                },
                                new EdgeButton
                                {
                                    Icon = LucideIconKind.X,
                                    Variant = EdgeButtonVariant.Ghost
                                },
                                new EdgeButton
                                {
                                    Text = "Dismiss",
                                    Icon = LucideIconKind.X,
                                    Variant = EdgeButtonVariant.Ghost
                                },
                                new EdgeButton
                                {
                                    Text = "Dismiss",
                                    Variant = EdgeButtonVariant.Ghost,
                                    IsEnabled = false
                                },
                            }
                        }
                    }
                },
                new StackPanel
                {
                    Orientation = Avalonia.Layout.Orientation.Vertical,
                    Spacing = 8,
                    Children =
                    {
                        new TextBlock
                        {
                            Text = "Outline",
                            Foreground = Brushes.White
                        },
                        new StackPanel {
                            Orientation = Avalonia.Layout.Orientation.Horizontal,
                            Spacing = 8,
                            Children =
                            {
                                new EdgeButton
                                {
                                    Text = "Restore",
                                    Variant = EdgeButtonVariant.Outline
                                },
                                new EdgeButton
                                {
                                    Icon = LucideIconKind.Undo2,
                                    Variant = EdgeButtonVariant.Outline
                                },
                                new EdgeButton
                                {
                                    Text = "Restore",
                                    Icon = LucideIconKind.Undo2,
                                    Variant = EdgeButtonVariant.Outline
                                },
                                new EdgeButton
                                {
                                    Text = "Restore",
                                    Variant = EdgeButtonVariant.Outline,
                                    IsEnabled = false
                                },
                            }
                        }
                    }
                },
                new StackPanel
                {
                    Orientation = Avalonia.Layout.Orientation.Vertical,
                    Spacing = 8,
                    Children =
                    {
                        new TextBlock
                        {
                            Text = "Destructive",
                            Foreground = Brushes.White
                        },
                        new StackPanel {
                            Orientation = Avalonia.Layout.Orientation.Horizontal,
                            Spacing = 8,
                            Children =
                            {
                                new EdgeButton
                                {
                                    Text = "Delete",
                                    Variant = EdgeButtonVariant.Destructive
                                },
                                new EdgeButton
                                {
                                    Icon = LucideIconKind.Trash2,
                                    Variant = EdgeButtonVariant.Destructive
                                },
                                new EdgeButton
                                {
                                    Text = "Delete",
                                    Icon = LucideIconKind.Trash2,
                                    Variant = EdgeButtonVariant.Destructive
                                },
                                new EdgeButton
                                {
                                    Text = "Delete",
                                    Variant = EdgeButtonVariant.Destructive,
                                    IsEnabled = false
                                },
                            }
                        }
                    }
                },
            }
        };
    }
}
