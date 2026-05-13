using Avalonia;
using Avalonia.Animation;
using Avalonia.Animation.Easings;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.Transformation;
using Avalonia.Styling;
using Lucide.Avalonia;

namespace EdgeUI.Controls;

public class EdgeButton : Button
{
    private bool _isHovered;
    private bool _isPressed;

    private readonly StackPanel _content;

    /// <summary>
    /// Text StyledProperty definition
    /// </summary>
    public static readonly StyledProperty<string?> TextProperty =
        AvaloniaProperty.Register<EdgeButton, string?>(nameof(Text));

    /// <summary>
    /// Gets or sets the Text property. This StyledProperty
    /// indicates ....
    /// </summary>
    public string? Text
    {
        get => this.GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    /// <summary>
    /// Variant StyledProperty definition
    /// </summary>
    public static readonly StyledProperty<EdgeButtonVariant> VariantProperty =
        AvaloniaProperty.Register<EdgeButton, EdgeButtonVariant>(nameof(Variant));

    /// <summary>
    /// Gets or sets the Variant property. This StyledProperty
    /// indicates ....
    /// </summary>
    public EdgeButtonVariant Variant
    {
        get => this.GetValue(VariantProperty);
        set => SetValue(VariantProperty, value);
    }

    /// <summary>
    /// Icon StyledProperty definition
    /// </summary>
    public static readonly StyledProperty<LucideIconKind?> IconProperty =
        AvaloniaProperty.Register<EdgeButton, LucideIconKind?>(nameof(Icon));

    /// <summary>
    /// Gets or sets the Icon property. This StyledProperty
    /// indicates ....
    /// </summary>
    public LucideIconKind? Icon
    {
        get => this.GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    static EdgeButton()
    {
        VariantProperty.Changed.AddClassHandler<EdgeButton>((x, e) => x.UpdateVariant());
        IconProperty.Changed.AddClassHandler<EdgeButton>((x, e) => x.UpdateContent());
        TextProperty.Changed.AddClassHandler<EdgeButton>((x, e) => x.UpdateContent());
    }

    public EdgeButton()
    {
        MinWidth = 32;
        MinHeight = 32;

        Padding = new Thickness(8);

        ClickMode = ClickMode.Release;

        HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Left;
        VerticalAlignment = Avalonia.Layout.VerticalAlignment.Top;

        HorizontalContentAlignment = Avalonia.Layout.HorizontalAlignment.Center;
        VerticalContentAlignment = Avalonia.Layout.VerticalAlignment.Center;

        Transitions = new Transitions
        {
            new TransformOperationsTransition
            {
                Property = RenderTransformProperty,
                Duration = TimeSpan.FromMilliseconds(200),
                Easing = new QuadraticEaseOut()
            }
        };

        _content = new StackPanel
        {
            Orientation = Avalonia.Layout.Orientation.Horizontal
        };

        Content = _content;

        WireEvents();
    }

    private void UpdateVariant()
    {
        switch (Variant)
        {
            case EdgeButtonVariant.Default:
                Foreground = Brushes.Blue;
                break;
            case EdgeButtonVariant.Primary:
                Foreground = Brushes.Purple;
                break;
            case EdgeButtonVariant.Secondary:
                break;
            case EdgeButtonVariant.Ghost:
                break;
            default:
                break;
        }
    }

    private void UpdateContent()
    {
        _content.Children.Clear();

        if (Icon != null)
        {
            _content.Children.Add(new LucideIcon
            {
                Kind = Icon,
                Size = 16
            });
        }

        if (!string.IsNullOrWhiteSpace(Text))
        {
            _content.Children.Add(new TextBlock
            {
                Text = Text,
                VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center
            });

            Padding = new Thickness(8, 8, 12, 8);
        }

        if (Icon != null && !string.IsNullOrWhiteSpace(Text))
        {
            _content.Spacing = 8;
        }
        else
        {
            _content.Spacing = 0;
        }
    }

    

    private void WireEvents()
    {
        PointerEntered += (_, _) => HandlePointerEntered();
        PointerExited += (_, _) => HandlePointerExited();
        PointerPressed += (_, _) => HandlePointerPressed();
        PointerReleased += (_, _) => HandlePointerReleased();
    }

    protected virtual void OnEdgePointerEntered() { }
    private void HandlePointerEntered()
    {
        _isHovered = true;
        HandleHoverState();
        OnEdgePointerEntered();
    }

    protected virtual void OnEdgePointerExited() { }
    private void HandlePointerExited()
    {
        _isHovered = false;
        HandleHoverState();
        OnEdgePointerExited();
    }

    private void HandleHoverState()
    {
        switch (Variant)
        {
            case EdgeButtonVariant.Default:
                if (_isHovered)
                {
                    Background = Brushes.Yellow;
                }
                else
                {
                    Background = Brushes.Transparent;
                }
                break;
            case EdgeButtonVariant.Primary:
                if (_isHovered)
                {
                    Background = Brushes.Red;
                }
                else
                {
                    Background = Brushes.Transparent;
                }
                break;
            case EdgeButtonVariant.Secondary:
                break;
            case EdgeButtonVariant.Ghost:
                break;
            default:
                break;
        }
    }

    protected virtual void OnEdgePointerPressed() { }
    private void HandlePointerPressed()
    {
        _isPressed = true;

        RenderTransform = new ScaleTransform(0.9, 0.9);

        OnEdgePointerPressed();
    }

    protected virtual void OnEdgePointerReleased() { }
    private void HandlePointerReleased()
    {
        _isPressed = false;
        
        RenderTransform = new ScaleTransform(1.0, 1.0);
        OnEdgePointerReleased();
    }
}

public enum EdgeButtonVariant
{
    Default,
    Primary,
    Secondary,
    Ghost
}