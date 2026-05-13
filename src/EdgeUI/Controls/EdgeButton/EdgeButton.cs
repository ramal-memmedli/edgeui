using Avalonia;
using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.Transformation;
using Lucide.Avalonia;

namespace EdgeUI.Controls.EdgeButton;

public class EdgeButton : Button
{
    private bool _isHovered;
    private bool _isPressed;
    private bool _isDisabled;
    private bool _isLoading;

    private readonly StackPanel _content = new StackPanel
        {
        Orientation = Avalonia.Layout.Orientation.Horizontal
    };

    private TextBlock? _text;

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
        VariantProperty.Changed.AddClassHandler<EdgeButton>((x, e) => x.ApplyVariant());
        IconProperty.Changed.AddClassHandler<EdgeButton>((x, e) => x.UpdateContent());
        TextProperty.Changed.AddClassHandler<EdgeButton>((x, e) => x.UpdateContent());
    }

    public EdgeButton()
    {
        Content = _content;

        ApplyInitialStyles();

        WireEvents();
    }

    private void ApplyInitialStyles()
    {
        MinWidth = 32;
        MinHeight = 32;

        Padding = new Thickness(8);

        ClickMode = ClickMode.Release;

        HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Left;
        VerticalAlignment = Avalonia.Layout.VerticalAlignment.Top;
        HorizontalContentAlignment = Avalonia.Layout.HorizontalAlignment.Center;
        VerticalContentAlignment = Avalonia.Layout.VerticalAlignment.Center;

        RenderTransformOrigin = RelativePoint.Center;

        Transitions = EdgeButtonTransitions();
    }

    private Transitions EdgeButtonTransitions()
    {
        return new Transitions
        {
            new TransformOperationsTransition
            {
                Property = RenderTransformProperty,
                Duration = TimeSpan.FromMilliseconds(250)
            },
            new BrushTransition
            {
                Property = BackgroundProperty,
                Duration = TimeSpan.FromMilliseconds(250)
            }
        };
    }

    private void ApplyVariant()
    {
        switch (Variant)
        {
            case EdgeButtonVariant.Primary:
                Background = new SolidColorBrush(Colors.White);
                break;
            case EdgeButtonVariant.Secondary:
                Background = new SolidColorBrush(Colors.White, 0.2);
                break;
            case EdgeButtonVariant.Ghost:
                Background = new SolidColorBrush(Colors.White, 0);
                break;
            case EdgeButtonVariant.Outline:
                Background = Brushes.Gray;
                BorderBrush = Brushes.Wheat;
                break;
            case EdgeButtonVariant.Destructive:
                Background = Brushes.Red;
                break;
            default:
                break;
        }
    }

    private void UpdateStyle()
    {
        EdgeButtonStyle style = ResolveStyle();

        if(_isHovered)
        {
            Background = style.Background;
            if(_text != null)
        }
    }

    private EdgeButtonStyle ResolveStyle()
    {
        EdgeButtonStyle style;

        switch (Variant)
        {
            case EdgeButtonVariant.Primary:
                style = EdgeButtonStyles.Primary;
                break;
            case EdgeButtonVariant.Secondary:
                style = EdgeButtonStyles.Primary;
                break;
            case EdgeButtonVariant.Ghost:
                style = EdgeButtonStyles.Primary;
                break;
            case EdgeButtonVariant.Outline:
                style = EdgeButtonStyles.Primary;
                break;
            case EdgeButtonVariant.Destructive:
                style = EdgeButtonStyles.Primary;
                break;
            default:
                style = EdgeButtonStyles.Primary;
                break;
        }

        return style;
    }

    private void UpdateContent()
    {
        _content.Children.Clear();

        if (Icon != null)
        {
            LucideIcon icon = new LucideIcon
            {
                Kind = Icon,
                Size = 16
            };
            _content.Children.Add(icon);
        }

        if (!string.IsNullOrWhiteSpace(Text))
        {
            _text = new TextBlock
            {
                Text = Text,
                VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
                Foreground = new SolidColorBrush(Colors.White, 0.65),
                Transitions = new Transitions
                {
                    new BrushTransition
                    {
                        Property = ForegroundProperty,
                        Duration = TimeSpan.FromMilliseconds(250)
                    }
                }
            };

            _content.Children.Add(_text);

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
            case EdgeButtonVariant.Primary:
                break;
            case EdgeButtonVariant.Secondary:
                break;
            case EdgeButtonVariant.Ghost:
                if (_isHovered)
                {
                    Background = new SolidColorBrush(Colors.White, 0.05);
                    if(_text != null)
                    {
                        _text.Foreground = new SolidColorBrush(Colors.White, 1);
                    }
                } else
                {
                    Background = new SolidColorBrush(Colors.White, 0);
                    if (_text != null)
                    {
                        _text.Foreground = new SolidColorBrush(Colors.White, 0.65);
                    }
                }
                break;
            case EdgeButtonVariant.Outline:
                break;
            case EdgeButtonVariant.Destructive:
                break;
            default:
                break;
        }
    }

    protected virtual void OnEdgePointerPressed() { }
    private void HandlePointerPressed()
    {
        _isPressed = true;

        var builder = TransformOperations.CreateBuilder(1);

        builder.AppendScale(0.9, 0.9);

        RenderTransform = builder.Build();

        OnEdgePointerPressed();
    }

    protected virtual void OnEdgePointerReleased() { }
    private void HandlePointerReleased()
    {
        _isPressed = false;

        var builder = TransformOperations.CreateBuilder(1);

        builder.AppendScale(1.0, 1.0);

        RenderTransform = builder.Build();

        OnEdgePointerReleased();
    }
}