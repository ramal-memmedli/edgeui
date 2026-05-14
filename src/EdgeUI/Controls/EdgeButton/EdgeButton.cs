using Avalonia;
using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Media.Transformation;
using Lucide.Avalonia;

namespace EdgeUI.Controls.EdgeButton;

public class EdgeButton : Button
{
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

    /// <summary>
    /// State StyledProperty definition
    /// </summary>
    public static readonly StyledProperty<EdgeButtonState> StateProperty =
        AvaloniaProperty.Register<EdgeButton, EdgeButtonState>(nameof(State));

    /// <summary>
    /// Gets or sets the State property. This StyledProperty
    /// indicates ....
    /// </summary>
    public EdgeButtonState State
    {
        get => this.GetValue(StateProperty);
        private set => SetValue(StateProperty, value);
    }

    private void SetState(EdgeButtonState state)
    {
        SetValue(StateProperty, state);
    }

    private readonly StackPanel _content = new StackPanel
    {
        Orientation = Avalonia.Layout.Orientation.Horizontal
    };

    private TextBlock _text = new TextBlock
    {
        VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
        Transitions = new Transitions
                {
                    new BrushTransition
                    {
                        Property = ForegroundProperty,
                        Duration = TimeSpan.FromMilliseconds(150)
                    }
                }
    };
    private LucideIcon _icon = new LucideIcon
    {
        Size = 16,
        Transitions = new Transitions
                {
                    new BrushTransition
                    {
                        Property = ForegroundProperty,
                        Duration = TimeSpan.FromMilliseconds(150)
                    }
                }
    };

    static EdgeButton()
    {
        VariantProperty.Changed.AddClassHandler<EdgeButton>((x, e) => x.UpdateStyle());
        IconProperty.Changed.AddClassHandler<EdgeButton>((x, e) => x.UpdateContent());
        TextProperty.Changed.AddClassHandler<EdgeButton>((x, e) => x.UpdateContent());
        IsEnabledProperty.Changed.AddClassHandler<EdgeButton>((x, e) => x.UpdateStyle());
    }

    public EdgeButton()
    {
        Content = _content;

        ApplyInitialStyles();
    }

    private void ApplyInitialStyles()
    {
        MinWidth = 32;
        MinHeight = 32;

        Padding = new Thickness(12, 8);

        ClickMode = ClickMode.Release;

        HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Left;
        VerticalAlignment = Avalonia.Layout.VerticalAlignment.Top;
        HorizontalContentAlignment = Avalonia.Layout.HorizontalAlignment.Center;
        VerticalContentAlignment = Avalonia.Layout.VerticalAlignment.Center;

        RenderTransformOrigin = RelativePoint.Center;

        EdgeButtonStyle style = ResolveStyle();
        Background = style.Background;
        _text.Foreground = style.Foreground;
        _icon.Foreground = style.Foreground;

        Transitions = EdgeButtonTransitions();
    }

    private Transitions EdgeButtonTransitions()
    {
        return new Transitions
        {
            new TransformOperationsTransition
            {
                Property = RenderTransformProperty,
                Duration = TimeSpan.FromMilliseconds(150)
            },
            new BrushTransition
            {
                Property = BackgroundProperty,
                Duration = TimeSpan.FromMilliseconds(150)
            },
            new BrushTransition
            {
                Property = BorderBrushProperty,
                Duration = TimeSpan.FromMilliseconds(150)
            }
        };
    }

    private void UpdateStyle()
    {
        EdgeButtonStyle style = ResolveStyle();

        BorderThickness = style.BorderThickness;

        if(State == EdgeButtonState.Hovered)
        {
            Background = style.HoverBackground;
            BorderBrush = style.HoverBorder;
            _text.Foreground = style.HoverForeground;
            _icon.Foreground = style.HoverForeground;
        }else if (State == EdgeButtonState.Pressed)
        {
            Background = style.PressBackground;
            BorderBrush = style.PressBorder;
            _text.Foreground = style.PressForeground;
            _icon.Foreground = style.PressForeground;
        }else if(!IsEnabled)
        {
            Opacity = 0.75;
        }
        else
        {
            Background = style.Background;
            BorderBrush = style.Border;
            _text.Foreground = style.Foreground;
            _icon.Foreground = style.Foreground;
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
                style = EdgeButtonStyles.Secondary;
                break;
            case EdgeButtonVariant.Ghost:
                style = EdgeButtonStyles.Ghost;
                break;
            case EdgeButtonVariant.Outline:
                style = EdgeButtonStyles.Outline;
                break;
            case EdgeButtonVariant.Destructive:
                style = EdgeButtonStyles.Destructive;
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
            _icon.Kind = Icon;
            _content.Children.Add(_icon);
        }

        if (!string.IsNullOrWhiteSpace(Text))
        {
            _text.Text = Text;
            _content.Children.Add(_text);
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

    protected override void OnPointerEntered(PointerEventArgs e)
    {
        base.OnPointerEntered(e);
        HandlePointerEntered();
    }

    protected override void OnPointerExited(PointerEventArgs e)
    {
        base.OnPointerExited(e);
        HandlePointerExited();
    }

    protected override void OnPointerPressed(PointerPressedEventArgs e)
    {
        base.OnPointerPressed(e);
        HandlePointerPressed();
    }

    protected override void OnPointerReleased(PointerReleasedEventArgs e)
    {
        base.OnPointerReleased(e);
        HandlePointerReleased();
    }

    protected virtual void OnEdgePointerEntered() { }
    protected virtual void OnEdgePointerExited() { }
    protected virtual void OnEdgePointerPressed() { }
    protected virtual void OnEdgePointerReleased() { }

    private void HandlePointerEntered()
    {
        SetState(EdgeButtonState.Hovered);
        UpdateStyle();
        OnEdgePointerEntered();
    }

    private void HandlePointerExited()
    {
        SetState(EdgeButtonState.Normal);
        UpdateStyle();
        OnEdgePointerExited();
    }

    private void HandlePointerPressed()
    {
        SetState(EdgeButtonState.Pressed);

        var builder = TransformOperations.CreateBuilder(1);

        builder.AppendScale(0.95, 0.95);

        RenderTransform = builder.Build();

        OnEdgePointerPressed();
    }

    private void HandlePointerReleased()
    {
        SetState(EdgeButtonState.Normal);

        var builder = TransformOperations.CreateBuilder(1);

        builder.AppendScale(1.0, 1.0);

        RenderTransform = builder.Build();

        OnEdgePointerReleased();
    }
}