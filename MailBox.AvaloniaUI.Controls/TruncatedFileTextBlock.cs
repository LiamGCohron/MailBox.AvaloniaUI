using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace MailBox.AvaloniaUI.Controls;
public class TruncatedFileTextBlock : Panel {
    private TextBlock folderTextBlock;
    private TextBlock separatorTextBlock;
    private TextBlock fileTextBlock;

    public static readonly StyledProperty<TextTrimming> FolderTextTrimmingProperty =
        AvaloniaProperty.Register<TruncatedFileTextBlock, TextTrimming>(nameof(FolderTextTrimming), TextTrimming.CharacterEllipsis);

    public static readonly StyledProperty<double> SpacingProperty =
        AvaloniaProperty.Register<TruncatedFileTextBlock, double>(nameof(Spacing));

    public static readonly StyledProperty<string> FolderTextProperty =
        AvaloniaProperty.Register<TruncatedFileTextBlock, string>(nameof(FolderText), string.Empty);

    public static readonly StyledProperty<string> SeparatorTextProperty =
        AvaloniaProperty.Register<TruncatedFileTextBlock, string>(nameof(SeparatorText), " - ");

    public static readonly StyledProperty<string> FileTextProperty =
        AvaloniaProperty.Register<TruncatedFileTextBlock, string>(nameof(FileText), string.Empty);

    public static readonly StyledProperty<IBrush> DefaultForegroundProperty =
        AvaloniaProperty.Register<TruncatedFileTextBlock, IBrush>(nameof(DefaultForeground), new SolidColorBrush(Colors.Black));

    public static readonly StyledProperty<IBrush?> FolderForegroundProperty =
        AvaloniaProperty.Register<TruncatedFileTextBlock, IBrush?>(nameof(FolderForeground));

    public static readonly StyledProperty<IBrush?> SeparatorForegroundProperty =
        AvaloniaProperty.Register<TruncatedFileTextBlock, IBrush?>(nameof(SeparatorForeground));

    public static readonly StyledProperty<IBrush?> FileForegroundProperty =
        AvaloniaProperty.Register<TruncatedFileTextBlock, IBrush?>(nameof(FileForeground));

    public static readonly StyledProperty<double> DefaultFontSizeProperty =
        AvaloniaProperty.Register<TruncatedFileTextBlock, double>(nameof(DefaultFontSize), 14);

    public static readonly StyledProperty<double?> FolderFontSizeProperty =
        AvaloniaProperty.Register<TruncatedFileTextBlock, double?>(nameof(FolderFontSize));

    public static readonly StyledProperty<double?> SeparatorFontSizeProperty =
        AvaloniaProperty.Register<TruncatedFileTextBlock, double?>(nameof(SeparatorFontSize));

    public static readonly StyledProperty<double?> FileFontSizeProperty =
        AvaloniaProperty.Register<TruncatedFileTextBlock, double?>(nameof(FileFontSize));

    public static readonly StyledProperty<FontWeight> DefaultFontWeightProperty =
        AvaloniaProperty.Register<TruncatedFileTextBlock, FontWeight>(nameof(DefaultFontWeight), FontWeight.Normal);

    public static readonly StyledProperty<FontWeight?> FolderFontWeightProperty =
        AvaloniaProperty.Register<TruncatedFileTextBlock, FontWeight?>(nameof(FolderFontWeight));

    public static readonly StyledProperty<FontWeight?> SeparatorFontWeightProperty =
        AvaloniaProperty.Register<TruncatedFileTextBlock, FontWeight?>(nameof(SeparatorFontWeight));

    public static readonly StyledProperty<FontWeight?> FileFontWeightProperty =
        AvaloniaProperty.Register<TruncatedFileTextBlock, FontWeight?>(nameof(FileFontWeight));

    public TextTrimming FolderTextTrimming {
        get => GetValue(FolderTextTrimmingProperty);
        set => SetValue(FolderTextTrimmingProperty, value);
    }

    public double Spacing {
        get => GetValue(SpacingProperty);
        set => SetValue(SpacingProperty, value);
    }

    public string FolderText {
        get => GetValue(FolderTextProperty);
        set => SetValue(FolderTextProperty, value);
    }

    public string SeparatorText {
        get => GetValue(SeparatorTextProperty);
        set => SetValue(SeparatorTextProperty, value);
    }

    public string FileText {
        get => GetValue(FileTextProperty);
        set => SetValue(FileTextProperty, value);
    }

    public IBrush DefaultForeground {
        get => GetValue(DefaultForegroundProperty);
        set => SetValue(DefaultForegroundProperty, value);
    }

    public IBrush? FolderForeground {
        get => GetValue(FolderForegroundProperty);
        set => SetValue(FolderForegroundProperty, value);
    }

    public IBrush? SeparatorForeground {
        get => GetValue(SeparatorForegroundProperty);
        set => SetValue(SeparatorForegroundProperty, value);
    }

    public IBrush? FileForeground {
        get => GetValue(FileForegroundProperty);
        set => SetValue(FileForegroundProperty, value);
    }

    public double DefaultFontSize {
        get => GetValue(DefaultFontSizeProperty);
        set => SetValue(DefaultFontSizeProperty, value);
    }

    public double? FolderFontSize {
        get => GetValue(FolderFontSizeProperty);
        set => SetValue(FolderFontSizeProperty, value);
    }

    public double? SeparatorFontSize {
        get => GetValue(SeparatorFontSizeProperty);
        set => SetValue(SeparatorFontSizeProperty, value);
    }

    public double? FileFontSize {
        get => GetValue(FileFontSizeProperty);
        set => SetValue(FileFontSizeProperty, value);
    }

    public FontWeight DefaultFontWeight {
        get => GetValue(DefaultFontWeightProperty);
        set => SetValue(DefaultFontWeightProperty, value);
    }

    public FontWeight? FolderFontWeight {
        get => GetValue(FolderFontWeightProperty);
        set => SetValue(FolderFontWeightProperty, value);
    }

    public FontWeight? SeparatorFontWeight {
        get => GetValue(SeparatorFontWeightProperty);
        set => SetValue(SeparatorFontWeightProperty, value);
    }

    public FontWeight? FileFontWeight {
        get => GetValue(FileFontWeightProperty);
        set => SetValue(FileFontWeightProperty, value);
    }

    static TruncatedFileTextBlock() {
        // Register property change handlers
        FolderTextTrimmingProperty.Changed.AddClassHandler<TruncatedFileTextBlock>((x, e) => x.OnFolderTextTrimmingChanged());

        FolderTextProperty.Changed.AddClassHandler<TruncatedFileTextBlock>((x, e) => x.OnFolderTextChanged());
        SeparatorTextProperty.Changed.AddClassHandler<TruncatedFileTextBlock>((x, e) => x.OnSeparatorTextChanged());
        FileTextProperty.Changed.AddClassHandler<TruncatedFileTextBlock>((x, e) => x.OnFileTextChanged());

        DefaultForegroundProperty.Changed.AddClassHandler<TruncatedFileTextBlock>((x, e) => x.OnDefaultForegroundChanged());
        FolderForegroundProperty.Changed.AddClassHandler<TruncatedFileTextBlock>((x, e) => x.OnFolderForegroundChanged());
        SeparatorForegroundProperty.Changed.AddClassHandler<TruncatedFileTextBlock>((x, e) => x.OnSeparatorForegroundChanged());
        FileForegroundProperty.Changed.AddClassHandler<TruncatedFileTextBlock>((x, e) => x.OnFileForegroundChanged());

        DefaultFontSizeProperty.Changed.AddClassHandler<TruncatedFileTextBlock>((x, e) => x.OnDefaultFontSizeChanged());
        FolderFontSizeProperty.Changed.AddClassHandler<TruncatedFileTextBlock>((x, e) => x.OnFolderFontSizeChanged());
        SeparatorFontSizeProperty.Changed.AddClassHandler<TruncatedFileTextBlock>((x, e) => x.OnSeparatorFontSizeChanged());
        FileFontSizeProperty.Changed.AddClassHandler<TruncatedFileTextBlock>((x, e) => x.OnFileFontSizeChanged());

        DefaultFontWeightProperty.Changed.AddClassHandler<TruncatedFileTextBlock>((x, e) => x.OnDefaultFontWeightChanged());
        FolderFontWeightProperty.Changed.AddClassHandler<TruncatedFileTextBlock>((x, e) => x.OnFolderFontWeightChanged());
        SeparatorFontWeightProperty.Changed.AddClassHandler<TruncatedFileTextBlock>((x, e) => x.OnSeparatorFontWeightChanged());
        FileFontWeightProperty.Changed.AddClassHandler<TruncatedFileTextBlock>((x, e) => x.OnFileFontWeightChanged());
    }

    public TruncatedFileTextBlock() {
        InitializeTextBlocks();
    }

    private void InitializeTextBlocks() {
        folderTextBlock = new TextBlock {
            Text = FolderText,
            TextTrimming = FolderTextTrimming,
            VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center
        };

        separatorTextBlock = new TextBlock {
            Text = SeparatorText,
            VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center
        };

        fileTextBlock = new TextBlock {
            Text = FileText,
            VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center
        };

        // Add to children collection
        Children.Add(folderTextBlock);
        Children.Add(separatorTextBlock);
        Children.Add(fileTextBlock);

        // Apply initial styling
        ApplyTextBlockStyles();
    }

    private void ApplyTextBlockStyles() {
        folderTextBlock.Foreground = FolderForeground ?? DefaultForeground;
        separatorTextBlock.Foreground = SeparatorForeground ?? DefaultForeground;
        fileTextBlock.Foreground = FileForeground ?? DefaultForeground;

        folderTextBlock.FontWeight = FolderFontWeight ?? DefaultFontWeight;
        separatorTextBlock.FontWeight = SeparatorFontWeight ?? DefaultFontWeight;
        fileTextBlock.FontWeight = FileFontWeight ?? DefaultFontWeight;
    }

    protected override Size MeasureOverride(Size availableSize) {
        if(folderTextBlock == null || separatorTextBlock == null || fileTextBlock == null) {
            return Size.Infinity;
        }

        // Measure separator and second TextBlock with unlimited width to get their natural sizes
        separatorTextBlock.Measure(new Size(double.PositiveInfinity, availableSize.Height));
        fileTextBlock.Measure(new Size(double.PositiveInfinity, availableSize.Height));

        double separatorWidth = separatorTextBlock.DesiredSize.Width;
        double FileTextWidth = fileTextBlock.DesiredSize.Width;

        // Calculate the maximum width available for the first TextBlock
        double maxFolderTextWidth = Math.Max(0, availableSize.Width - separatorWidth - FileTextWidth - (Spacing * 2));

        // Measure the first TextBlock with the calculated maximum width
        folderTextBlock.Measure(new Size(maxFolderTextWidth, availableSize.Height));
        double FolderTextWidth = folderTextBlock.DesiredSize.Width;

        // Calculate total size needed
        double totalWidth = FolderTextWidth + Spacing + separatorWidth + Spacing + FileTextWidth;
        double totalHeight = Math.Max(folderTextBlock.DesiredSize.Height,
                                 Math.Max(separatorTextBlock.DesiredSize.Height, fileTextBlock.DesiredSize.Height));

        return new Size(Math.Min(totalWidth, availableSize.Width), totalHeight);
    }

    protected override Size ArrangeOverride(Size finalSize) {
        if(folderTextBlock == null || separatorTextBlock == null || fileTextBlock == null) {
            return finalSize;
        }

        // Measure separator and second TextBlock to get their natural widths
        separatorTextBlock.Measure(new Size(double.PositiveInfinity, finalSize.Height));
        fileTextBlock.Measure(new Size(double.PositiveInfinity, finalSize.Height));

        double separatorWidth = separatorTextBlock.DesiredSize.Width;
        double FileTextWidth = fileTextBlock.DesiredSize.Width;

        // Calculate available width for first TextBlock
        double maxFolderTextWidth = Math.Max(0, finalSize.Width - separatorWidth - FileTextWidth - (Spacing * 2));

        // Measure first TextBlock with the calculated constraint to get its actual desired width
        folderTextBlock.Measure(new Size(maxFolderTextWidth, finalSize.Height));
        double FolderTextDesiredWidth = folderTextBlock.DesiredSize.Width;

        // Use the minimum of desired width and max width for the first TextBlock
        double FolderTextActualWidth = Math.Min(FolderTextDesiredWidth, maxFolderTextWidth);

        // Arrange first TextBlock
        Rect FolderTextRect = new Rect(0, 0, FolderTextActualWidth, finalSize.Height);
        folderTextBlock.Arrange(FolderTextRect);

        // Position separator TextBlock after the first TextBlock
        double separatorX = FolderTextActualWidth + Spacing;
        Rect separatorRect = new Rect(separatorX, 0, separatorWidth, finalSize.Height);
        separatorTextBlock.Arrange(separatorRect);

        // Position second TextBlock after the separator
        double FileTextX = separatorX + separatorWidth + Spacing;
        Rect FileTextRect = new Rect(FileTextX, 0, FileTextWidth, finalSize.Height);
        fileTextBlock.Arrange(FileTextRect);

        return finalSize;
    }

    // Property change handlers
    private void OnFolderTextTrimmingChanged() {
        if(folderTextBlock != null) {
            folderTextBlock.TextTrimming = FolderTextTrimming;
            InvalidateMeasure();
        }
    }

    private void OnFolderTextChanged() {
        if(folderTextBlock != null) {
            folderTextBlock.Text = FolderText;
            InvalidateMeasure();
        }
    }

    private void OnSeparatorTextChanged() {
        if(separatorTextBlock != null) {
            separatorTextBlock.Text = SeparatorText;
            InvalidateMeasure();
        }
    }

    private void OnFileTextChanged() {
        if(fileTextBlock != null) {
            fileTextBlock.Text = FileText;
            InvalidateMeasure();
        }
    }

    private void OnDefaultForegroundChanged() {
        if(folderTextBlock != null) {
            folderTextBlock.Foreground = FolderForeground ?? DefaultForeground;
            InvalidateVisual();
        }

        if(separatorTextBlock != null) {
            separatorTextBlock.Foreground = SeparatorForeground ?? DefaultForeground;
            InvalidateVisual();
        }

        if(fileTextBlock != null) {
            fileTextBlock.Foreground = FileForeground ?? DefaultForeground;
            InvalidateVisual();
        }
    }

    private void OnFolderForegroundChanged() {
        if(folderTextBlock != null && FolderForeground != null) {
            folderTextBlock.Foreground = FolderForeground ?? DefaultForeground;
            InvalidateVisual();
        }
    }

    private void OnSeparatorForegroundChanged() {
        if(separatorTextBlock != null && SeparatorForeground != null) {
            separatorTextBlock.Foreground = SeparatorForeground ?? DefaultForeground;
            InvalidateVisual();
        }
    }

    private void OnFileForegroundChanged() {
        if(fileTextBlock != null && FileForeground != null) {
            fileTextBlock.Foreground = FileForeground ?? DefaultForeground;
            InvalidateVisual();
        }
    }

    private void OnDefaultFontSizeChanged() {
        if(folderTextBlock != null) {
            folderTextBlock.FontSize = FolderFontSize ?? DefaultFontSize;
            InvalidateVisual();
        }

        if(separatorTextBlock != null) {
            separatorTextBlock.FontSize = SeparatorFontSize ?? DefaultFontSize;
            InvalidateVisual();
        }

        if(fileTextBlock != null) {
            fileTextBlock.FontSize = SeparatorFontSize ?? DefaultFontSize;
            InvalidateVisual();
        }
    }

    private void OnFolderFontSizeChanged() {
        if(folderTextBlock != null && FolderFontSize != null) {
            folderTextBlock.FontSize = FolderFontSize ?? DefaultFontSize;
            InvalidateVisual();
        }
    }

    private void OnSeparatorFontSizeChanged() {
        if(separatorTextBlock != null && SeparatorFontSize != null) {
            separatorTextBlock.FontSize = SeparatorFontSize ?? DefaultFontSize;
            InvalidateVisual();
        }
    }

    private void OnFileFontSizeChanged() {
        if(fileTextBlock != null && FileFontSize != null) {
            fileTextBlock.FontSize = FileFontSize ?? DefaultFontSize;
            InvalidateVisual();
        }
    }

    private void OnDefaultFontWeightChanged() {
        if(folderTextBlock != null) {
            folderTextBlock.FontWeight = FolderFontWeight ?? DefaultFontWeight;
            InvalidateVisual();
        }

        if(separatorTextBlock != null) {
            separatorTextBlock.FontWeight = SeparatorFontWeight ?? DefaultFontWeight;
            InvalidateVisual();
        }

        if(fileTextBlock != null) {
            fileTextBlock.FontWeight = FileFontWeight ?? DefaultFontWeight;
            InvalidateVisual();
        }
    }

    private void OnFolderFontWeightChanged() {
        if(folderTextBlock != null && FolderFontWeight != null) {
            folderTextBlock.FontWeight = FolderFontWeight ?? DefaultFontWeight;
            InvalidateVisual();
        }
    }

    private void OnSeparatorFontWeightChanged() {
        if(separatorTextBlock != null && SeparatorFontWeight != null) {
            separatorTextBlock.FontWeight = SeparatorFontWeight ?? DefaultFontWeight;
            InvalidateVisual();
        }
    }

    private void OnFileFontWeightChanged() {
        if(fileTextBlock != null && FileFontWeight != null) {
            fileTextBlock.FontWeight = FileFontWeight ?? DefaultFontWeight;
            InvalidateVisual();
        }
    }
}
