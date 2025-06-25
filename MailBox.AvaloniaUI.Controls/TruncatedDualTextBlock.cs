using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace MailBox.AvaloniaUI.Controls;
public class TruncatedDualTextBlock : Panel {
    private readonly TextBlock leftTextBlock;
    private readonly TextBlock separatorTextBlock;
    private readonly TextBlock rightTextBlock;

    public static readonly StyledProperty<double> SpacingProperty =
        AvaloniaProperty.Register<TruncatedDualTextBlock, double>(nameof(Spacing));

    #region Text StyledProperties
    public static readonly StyledProperty<string> LeftTextProperty =
        AvaloniaProperty.Register<TruncatedDualTextBlock, string>(nameof(LeftText), string.Empty);

    public static readonly StyledProperty<string> SeparatorTextProperty =
        AvaloniaProperty.Register<TruncatedDualTextBlock, string>(nameof(SeparatorText), " - ");

    public static readonly StyledProperty<string> RightTextProperty =
        AvaloniaProperty.Register<TruncatedDualTextBlock, string>(nameof(RightText), string.Empty);
    #endregion

    #region Trimming StyledProperties
    public static readonly StyledProperty<TextTrimming> LeftTextTrimmingProperty =
        AvaloniaProperty.Register<TruncatedDualTextBlock, TextTrimming>(nameof(LeftTextTrimming), TextTrimming.CharacterEllipsis);
    public static readonly StyledProperty<TextTrimming> RightTextTrimmingProperty =
        AvaloniaProperty.Register<TruncatedDualTextBlock, TextTrimming>(nameof(RightTextTrimming), TextTrimming.CharacterEllipsis);
    #endregion

    #region Foreground StyledProperties
    public static readonly StyledProperty<IBrush> DefaultForegroundProperty =
        AvaloniaProperty.Register<TruncatedDualTextBlock, IBrush>(nameof(DefaultForeground), new SolidColorBrush(Colors.Black));

    public static readonly StyledProperty<IBrush?> LeftForegroundProperty =
        AvaloniaProperty.Register<TruncatedDualTextBlock, IBrush?>(nameof(LeftForeground));

    public static readonly StyledProperty<IBrush?> SeparatorForegroundProperty =
        AvaloniaProperty.Register<TruncatedDualTextBlock, IBrush?>(nameof(SeparatorForeground));

    public static readonly StyledProperty<IBrush?> RightForegroundProperty =
        AvaloniaProperty.Register<TruncatedDualTextBlock, IBrush?>(nameof(RightForeground));
    #endregion

    #region Font Size StyledProperties
    public static readonly StyledProperty<double> DefaultFontSizeProperty =
        AvaloniaProperty.Register<TruncatedDualTextBlock, double>(nameof(DefaultFontSize), 14);

    public static readonly StyledProperty<double?> LeftFontSizeProperty =
        AvaloniaProperty.Register<TruncatedDualTextBlock, double?>(nameof(LeftFontSize));

    public static readonly StyledProperty<double?> SeparatorFontSizeProperty =
        AvaloniaProperty.Register<TruncatedDualTextBlock, double?>(nameof(SeparatorFontSize));

    public static readonly StyledProperty<double?> RightFontSizeProperty =
        AvaloniaProperty.Register<TruncatedDualTextBlock, double?>(nameof(RightFontSize));
    #endregion

    #region Font Weight StyledProperties
    public static readonly StyledProperty<FontWeight> DefaultFontWeightProperty =
        AvaloniaProperty.Register<TruncatedDualTextBlock, FontWeight>(nameof(DefaultFontWeight), FontWeight.Normal);

    public static readonly StyledProperty<FontWeight?> LeftFontWeightProperty =
        AvaloniaProperty.Register<TruncatedDualTextBlock, FontWeight?>(nameof(LeftFontWeight));

    public static readonly StyledProperty<FontWeight?> SeparatorFontWeightProperty =
        AvaloniaProperty.Register<TruncatedDualTextBlock, FontWeight?>(nameof(SeparatorFontWeight));

    public static readonly StyledProperty<FontWeight?> RightFontWeightProperty =
        AvaloniaProperty.Register<TruncatedDualTextBlock, FontWeight?>(nameof(RightFontWeight));
    #endregion

    #region Font Style StyledProperties
    public static readonly StyledProperty<FontStyle> DefaultFontStyleProperty =
        AvaloniaProperty.Register<TruncatedDualTextBlock, FontStyle>(nameof(DefaultFontStyle));

    public static readonly StyledProperty<FontStyle?> LeftFontStyleProperty =
        AvaloniaProperty.Register<TruncatedDualTextBlock, FontStyle?>(nameof(LeftFontStyle));

    public static readonly StyledProperty<FontStyle?> SeparatorFontStyleProperty =
        AvaloniaProperty.Register<TruncatedDualTextBlock, FontStyle?>(nameof(SeparatorFontStyle));

    public static readonly StyledProperty<FontStyle?> RightFontStyleProperty =
        AvaloniaProperty.Register<TruncatedDualTextBlock, FontStyle?>(nameof(RightFontStyle));
    #endregion

    public double Spacing {
        get => GetValue(SpacingProperty);
        set => SetValue(SpacingProperty, value);
    }

    #region Text Properties
    public string LeftText {
        get => GetValue(LeftTextProperty);
        set => SetValue(LeftTextProperty, value);
    }

    public string SeparatorText {
        get => GetValue(SeparatorTextProperty);
        set => SetValue(SeparatorTextProperty, value);
    }

    public string RightText {
        get => GetValue(RightTextProperty);
        set => SetValue(RightTextProperty, value);
    }
    #endregion

    #region Trimming Properties
    public TextTrimming LeftTextTrimming {
        get => GetValue(LeftTextTrimmingProperty);
        set => SetValue(LeftTextTrimmingProperty, value);
    }

    public TextTrimming RightTextTrimming {
        get => GetValue(RightTextTrimmingProperty);
        set => SetValue(RightTextTrimmingProperty, value);
    }
    #endregion

    #region Foreground Properties
    public IBrush DefaultForeground {
        get => GetValue(DefaultForegroundProperty);
        set => SetValue(DefaultForegroundProperty, value);
    }

    public IBrush? LeftForeground {
        get => GetValue(LeftForegroundProperty);
        set => SetValue(LeftForegroundProperty, value);
    }

    public IBrush? SeparatorForeground {
        get => GetValue(SeparatorForegroundProperty);
        set => SetValue(SeparatorForegroundProperty, value);
    }

    public IBrush? RightForeground {
        get => GetValue(RightForegroundProperty);
        set => SetValue(RightForegroundProperty, value);
    }
    #endregion

    #region Font Size Properties
    public double DefaultFontSize {
        get => GetValue(DefaultFontSizeProperty);
        set => SetValue(DefaultFontSizeProperty, value);
    }

    public double? LeftFontSize {
        get => GetValue(LeftFontSizeProperty);
        set => SetValue(LeftFontSizeProperty, value);
    }

    public double? SeparatorFontSize {
        get => GetValue(SeparatorFontSizeProperty);
        set => SetValue(SeparatorFontSizeProperty, value);
    }

    public double? RightFontSize {
        get => GetValue(RightFontSizeProperty);
        set => SetValue(RightFontSizeProperty, value);
    }
    #endregion

    #region Font Weight Properties
    public FontWeight DefaultFontWeight {
        get => GetValue(DefaultFontWeightProperty);
        set => SetValue(DefaultFontWeightProperty, value);
    }

    public FontWeight? LeftFontWeight {
        get => GetValue(LeftFontWeightProperty);
        set => SetValue(LeftFontWeightProperty, value);
    }

    public FontWeight? SeparatorFontWeight {
        get => GetValue(SeparatorFontWeightProperty);
        set => SetValue(SeparatorFontWeightProperty, value);
    }

    public FontWeight? RightFontWeight {
        get => GetValue(RightFontWeightProperty);
        set => SetValue(RightFontWeightProperty, value);
    }
    #endregion

    #region Font Style Properties
    public FontStyle DefaultFontStyle {
        get => GetValue(DefaultFontStyleProperty);
        set => SetValue(DefaultFontStyleProperty, value);
    }

    public FontStyle? LeftFontStyle {
        get => GetValue(LeftFontStyleProperty);
        set => SetValue(LeftFontStyleProperty, value);
    }

    public FontStyle? SeparatorFontStyle {
        get => GetValue(SeparatorFontStyleProperty);
        set => SetValue(SeparatorFontStyleProperty, value);
    }

    public FontStyle? RightFontStyle {
        get => GetValue(RightFontStyleProperty);
        set => SetValue(RightFontStyleProperty, value);
    }
    #endregion

    static TruncatedDualTextBlock() {
        SpacingProperty.Changed.AddClassHandler<TruncatedDualTextBlock>((x, e) => x.OnSpacingChanged());

        LeftTextProperty.Changed.AddClassHandler<TruncatedDualTextBlock>((x, e) => x.OnLeftTextChanged());
        SeparatorTextProperty.Changed.AddClassHandler<TruncatedDualTextBlock>((x, e) => x.OnSeparatorTextChanged());
        RightTextProperty.Changed.AddClassHandler<TruncatedDualTextBlock>((x, e) => x.OnRightTextChanged());

        LeftTextTrimmingProperty.Changed.AddClassHandler<TruncatedDualTextBlock>((x, e) => x.OnLeftTextTrimmingChanged());
        RightTextTrimmingProperty.Changed.AddClassHandler<TruncatedDualTextBlock>((x, e) => x.OnRightTextTrimmingChanged());

        DefaultForegroundProperty.Changed.AddClassHandler<TruncatedDualTextBlock>((x, e) => x.OnDefaultForegroundChanged());
        LeftForegroundProperty.Changed.AddClassHandler<TruncatedDualTextBlock>((x, e) => x.OnLeftForegroundChanged());
        SeparatorForegroundProperty.Changed.AddClassHandler<TruncatedDualTextBlock>((x, e) => x.OnSeparatorForegroundChanged());
        RightForegroundProperty.Changed.AddClassHandler<TruncatedDualTextBlock>((x, e) => x.OnRightForegroundChanged());

        DefaultFontSizeProperty.Changed.AddClassHandler<TruncatedDualTextBlock>((x, e) => x.OnDefaultFontSizeChanged());
        LeftFontSizeProperty.Changed.AddClassHandler<TruncatedDualTextBlock>((x, e) => x.OnLeftFontSizeChanged());
        SeparatorFontSizeProperty.Changed.AddClassHandler<TruncatedDualTextBlock>((x, e) => x.OnSeparatorFontSizeChanged());
        RightFontSizeProperty.Changed.AddClassHandler<TruncatedDualTextBlock>((x, e) => x.OnRightFontSizeChanged());

        DefaultFontWeightProperty.Changed.AddClassHandler<TruncatedDualTextBlock>((x, e) => x.OnDefaultFontWeightChanged());
        LeftFontWeightProperty.Changed.AddClassHandler<TruncatedDualTextBlock>((x, e) => x.OnLeftFontWeightChanged());
        SeparatorFontWeightProperty.Changed.AddClassHandler<TruncatedDualTextBlock>((x, e) => x.OnSeparatorFontWeightChanged());
        RightFontWeightProperty.Changed.AddClassHandler<TruncatedDualTextBlock>((x, e) => x.OnRightFontWeightChanged());

        DefaultFontStyleProperty.Changed.AddClassHandler<TruncatedDualTextBlock>((x, e) => x.OnDefaultFontStyleChanged());
        LeftFontStyleProperty.Changed.AddClassHandler<TruncatedDualTextBlock>((x, e) => x.OnLeftFontStyleChanged());
        SeparatorFontStyleProperty.Changed.AddClassHandler<TruncatedDualTextBlock>((x, e) => x.OnSeparatorFontStyleChanged());
        RightFontStyleProperty.Changed.AddClassHandler<TruncatedDualTextBlock>((x, e) => x.OnRightFontStyleChanged());
    }

    public TruncatedDualTextBlock() {
        leftTextBlock = new TextBlock {
            Text = LeftText,
            TextTrimming = LeftTextTrimming,
            VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
            Foreground = LeftForeground ?? DefaultForeground,
            FontWeight = LeftFontWeight ?? DefaultFontWeight,
            FontStyle = LeftFontStyle ?? DefaultFontStyle
        };

        separatorTextBlock = new TextBlock {
            Text = SeparatorText,
            TextTrimming = RightTextTrimming,
            VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
            Foreground = SeparatorForeground ?? DefaultForeground,
            FontWeight = SeparatorFontWeight ?? DefaultFontWeight,
            FontStyle = SeparatorFontStyle ?? DefaultFontStyle
        };

        rightTextBlock = new TextBlock {
            Text = RightText,
            VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
            Foreground = RightForeground ?? DefaultForeground,
            FontWeight = RightFontWeight ?? DefaultFontWeight,
            FontStyle = RightFontStyle ?? DefaultFontStyle,
        };

        // Add to children collection
        Children.Add(leftTextBlock);
        Children.Add(separatorTextBlock);
        Children.Add(rightTextBlock);

        // Apply initial styling
        ApplyTextBlockStyles();
    }

    private void ApplyTextBlockStyles() {
        leftTextBlock.Foreground = LeftForeground ?? DefaultForeground;
        separatorTextBlock.Foreground = SeparatorForeground ?? DefaultForeground;
        rightTextBlock.Foreground = RightForeground ?? DefaultForeground;

        leftTextBlock.FontWeight = LeftFontWeight ?? DefaultFontWeight;
        separatorTextBlock.FontWeight = SeparatorFontWeight ?? DefaultFontWeight;
        rightTextBlock.FontWeight = RightFontWeight ?? DefaultFontWeight;
    }

    protected override Size MeasureOverride(Size availableSize) {
        if(leftTextBlock == null || separatorTextBlock == null || rightTextBlock == null) {
            return Size.Infinity;
        }

        // Measure separator and second TextBlock with unlimited width to get their natural sizes
        separatorTextBlock.Measure(new Size(double.PositiveInfinity, availableSize.Height));
        rightTextBlock.Measure(new Size(double.PositiveInfinity, availableSize.Height));

        double separatorWidth = separatorTextBlock.DesiredSize.Width;
        double rightTextWidth = rightTextBlock.DesiredSize.Width;

        // Calculate the maximum width available for the first TextBlock
        double maxLeftTextWidth = Math.Max(0, availableSize.Width - separatorWidth - rightTextWidth - (Spacing * 2));

        // Measure the first TextBlock with the calculated maximum width
        leftTextBlock.Measure(new Size(maxLeftTextWidth, availableSize.Height));
        double leftTextWidth = leftTextBlock.DesiredSize.Width;

        // Calculate total size needed
        double totalWidth = leftTextWidth + Spacing + separatorWidth + Spacing + rightTextWidth;
        double totalHeight = Math.Max(leftTextBlock.DesiredSize.Height,
                                 Math.Max(separatorTextBlock.DesiredSize.Height, rightTextBlock.DesiredSize.Height));

        return new Size(Math.Min(totalWidth, availableSize.Width), totalHeight);
    }

    protected override Size ArrangeOverride(Size finalSize) {
        if(leftTextBlock == null || separatorTextBlock == null || rightTextBlock == null) {
            return finalSize;
        }

        // Measure separator and second TextBlock to get their natural widths
        separatorTextBlock.Measure(new Size(double.PositiveInfinity, finalSize.Height));
        rightTextBlock.Measure(new Size(double.PositiveInfinity, finalSize.Height));

        double separatorWidth = separatorTextBlock.DesiredSize.Width;
        double rightTextWidth = rightTextBlock.DesiredSize.Width;

        // Calculate available width for first TextBlock
        double maxLeftTextWidth = Math.Max(0, finalSize.Width - separatorWidth - rightTextWidth - (Spacing * 2));

        // Measure first TextBlock with the calculated constraint to get its actual desired width
        leftTextBlock.Measure(new Size(maxLeftTextWidth, finalSize.Height));
        double leftTextDesiredWidth = leftTextBlock.DesiredSize.Width;

        // Use the minimum of desired width and max width for the first TextBlock
        double leftTextActualWidth = Math.Min(leftTextDesiredWidth, maxLeftTextWidth);

        // Arrange first TextBlock
        Rect leftTextRect = new Rect(0, 0, leftTextActualWidth, finalSize.Height);
        leftTextBlock.Arrange(leftTextRect);

        // Position separator TextBlock after the first TextBlock
        double separatorX = leftTextActualWidth + Spacing;
        Rect separatorRect = new Rect(separatorX, 0, separatorWidth, finalSize.Height);
        separatorTextBlock.Arrange(separatorRect);

        // Position second TextBlock after the separator
        double rightTextX = separatorX + separatorWidth + Spacing;
        Rect rightTextRect = new Rect(rightTextX, 0, rightTextWidth, finalSize.Height);
        rightTextBlock.Arrange(rightTextRect);

        return finalSize;
    }

    // Property change handlers
    private void OnSpacingChanged() {
        InvalidateMeasure();
    }

    #region Text Change Handlers
    private void OnLeftTextChanged() {
        if(leftTextBlock != null) {
            leftTextBlock.Text = LeftText;
            InvalidateMeasure();
        }
    }

    private void OnSeparatorTextChanged() {
        if(separatorTextBlock != null) {
            separatorTextBlock.Text = SeparatorText;
            InvalidateMeasure();
        }
    }

    private void OnRightTextChanged() {
        if(rightTextBlock != null) {
            rightTextBlock.Text = RightText;
            InvalidateMeasure();
        }
    }
    #endregion

    #region Trimming Change Handlers
    private void OnLeftTextTrimmingChanged() {
        if(leftTextBlock != null) {
            leftTextBlock.TextTrimming = LeftTextTrimming;
            InvalidateMeasure();
        }
    }
    private void OnRightTextTrimmingChanged() {
        if(rightTextBlock != null) {
            rightTextBlock.TextTrimming = RightTextTrimming;
            InvalidateMeasure();
        }
    }
    #endregion

    #region Foreground Change Handlers
    private void OnDefaultForegroundChanged() {
        if(leftTextBlock != null) {
            leftTextBlock.Foreground = LeftForeground ?? DefaultForeground;
            InvalidateVisual();
        }

        if(separatorTextBlock != null) {
            separatorTextBlock.Foreground = SeparatorForeground ?? DefaultForeground;
            InvalidateVisual();
        }

        if(rightTextBlock != null) {
            rightTextBlock.Foreground = RightForeground ?? DefaultForeground;
            InvalidateVisual();
        }
    }

    private void OnLeftForegroundChanged() {
        if(leftTextBlock != null && LeftForeground != null) {
            leftTextBlock.Foreground = LeftForeground ?? DefaultForeground;
            InvalidateVisual();
        }
    }

    private void OnSeparatorForegroundChanged() {
        if(separatorTextBlock != null && SeparatorForeground != null) {
            separatorTextBlock.Foreground = SeparatorForeground ?? DefaultForeground;
            InvalidateVisual();
        }
    }

    private void OnRightForegroundChanged() {
        if(rightTextBlock != null && RightForeground != null) {
            rightTextBlock.Foreground = RightForeground ?? DefaultForeground;
            InvalidateVisual();
        }
    }
    #endregion

    #region Font Size Change Handlers
    private void OnDefaultFontSizeChanged() {
        if(leftTextBlock != null) {
            leftTextBlock.FontSize = LeftFontSize ?? DefaultFontSize;
            InvalidateVisual();
        }

        if(separatorTextBlock != null) {
            separatorTextBlock.FontSize = SeparatorFontSize ?? DefaultFontSize;
            InvalidateVisual();
        }

        if(rightTextBlock != null) {
            rightTextBlock.FontSize = RightFontSize ?? DefaultFontSize;
            InvalidateVisual();
        }
    }

    private void OnLeftFontSizeChanged() {
        if(leftTextBlock != null && LeftFontSize != null) {
            leftTextBlock.FontSize = LeftFontSize ?? DefaultFontSize;
            InvalidateVisual();
        }
    }

    private void OnSeparatorFontSizeChanged() {
        if(separatorTextBlock != null && SeparatorFontSize != null) {
            separatorTextBlock.FontSize = SeparatorFontSize ?? DefaultFontSize;
            InvalidateVisual();
        }
    }

    private void OnRightFontSizeChanged() {
        if(rightTextBlock != null && RightFontSize != null) {
            rightTextBlock.FontSize = RightFontSize ?? DefaultFontSize;
            InvalidateVisual();
        }
    }
    #endregion

    #region Font Weight Change Handlers
    private void OnDefaultFontWeightChanged() {
        if(leftTextBlock != null) {
            leftTextBlock.FontWeight = LeftFontWeight ?? DefaultFontWeight;
            InvalidateVisual();
        }

        if(separatorTextBlock != null) {
            separatorTextBlock.FontWeight = SeparatorFontWeight ?? DefaultFontWeight;
            InvalidateVisual();
        }

        if(rightTextBlock != null) {
            rightTextBlock.FontWeight = RightFontWeight ?? DefaultFontWeight;
            InvalidateVisual();
        }
    }

    private void OnLeftFontWeightChanged() {
        if(leftTextBlock != null && LeftFontWeight != null) {
            leftTextBlock.FontWeight = LeftFontWeight ?? DefaultFontWeight;
            InvalidateVisual();
        }
    }

    private void OnSeparatorFontWeightChanged() {
        if(separatorTextBlock != null && SeparatorFontWeight != null) {
            separatorTextBlock.FontWeight = SeparatorFontWeight ?? DefaultFontWeight;
            InvalidateVisual();
        }
    }

    private void OnRightFontWeightChanged() {
        if(rightTextBlock != null && RightFontWeight != null) {
            rightTextBlock.FontWeight = RightFontWeight ?? DefaultFontWeight;
            InvalidateVisual();
        }
    }
    #endregion

    #region Font Style Change Handlers
    private void OnDefaultFontStyleChanged() {
        if(leftTextBlock != null) {
            leftTextBlock.FontStyle = LeftFontStyle ?? DefaultFontStyle;
            InvalidateVisual();
        }

        if(separatorTextBlock != null) {
            separatorTextBlock.FontStyle = SeparatorFontStyle ?? DefaultFontStyle;
            InvalidateVisual();
        }

        if(rightTextBlock != null) {
            rightTextBlock.FontStyle = RightFontStyle ?? DefaultFontStyle;
            InvalidateVisual();
        }
    }

    private void OnLeftFontStyleChanged() {
        if(leftTextBlock != null && LeftFontStyle != null) {
            leftTextBlock.FontStyle = LeftFontStyle ?? DefaultFontStyle;
            InvalidateVisual();
        }
    }

    private void OnSeparatorFontStyleChanged() {
        if(separatorTextBlock != null && SeparatorFontStyle != null) {
            separatorTextBlock.FontStyle = SeparatorFontStyle ?? DefaultFontStyle;
            InvalidateVisual();
        }
    }

    private void OnRightFontStyleChanged() {
        if(rightTextBlock != null && RightFontStyle != null) {
            rightTextBlock.FontStyle = RightFontStyle ?? DefaultFontStyle;
            InvalidateVisual();
        }
    }
    #endregion



}
