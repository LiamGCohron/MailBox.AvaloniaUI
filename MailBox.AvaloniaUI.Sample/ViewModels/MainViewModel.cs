using System.Collections.Generic;

using Avalonia.Media;

using ReactiveUI.Fody.Helpers;

namespace MailBox.AvaloniaUI.Sample.ViewModels;

public class MainViewModel : ViewModelBase {
    [Reactive] public double Spacing { get; set; }

    #region Text
    [Reactive] public string LeftText { get; set; } = "E:/Projects/GitHub/MailBox.AvaloniaUI/VeryLongFolderNameThatTakesTooMuchSpace";
    [Reactive] public string SeparatorText { get; set; } = "/";
    [Reactive] public string RightText { get; set; } = "ImportantFileName.txt";
    #endregion

    #region Trimming
    [Reactive] public TextTrimming LeftTextTrimming { get; set; } = TextTrimming.CharacterEllipsis;
    [Reactive] public TextTrimming RightTextTrimming { get; set; } = TextTrimming.None;
    #endregion

    #region Foreground
    [Reactive] public IBrush LeftForeground { get; set; } = new SolidColorBrush(Colors.Red);
    [Reactive] public IBrush SeparatorForeground { get; set; } = new SolidColorBrush(Colors.Blue);
    [Reactive] public IBrush RightForeground { get; set; } = new SolidColorBrush(Colors.DarkGreen);
    #endregion

    #region Font Size
    [Reactive] public double LeftFontSize { get; set; } = 16;
    [Reactive] public double SeparatorFontSize { get; set; } = 24;
    [Reactive] public double RightFontSize { get; set; } = 20;
    #endregion

    #region Font Weight
    [Reactive] public FontWeight LeftFontWeight { get; set; } = FontWeight.Normal;
    [Reactive] public FontWeight SeparatorFontWeight { get; set; } = FontWeight.Normal;
    [Reactive] public FontWeight RightFontWeight { get; set; } = FontWeight.Normal;
    #endregion

    #region Font Style
    [Reactive] public FontStyle LeftFontStyle { get; set; }
    [Reactive] public FontStyle SeparatorFontStyle { get; set; }
    [Reactive] public FontStyle RightFontStyle { get; set; }
    #endregion

    public List<TextTrimming> TextTrimmings { get; } = [
        TextTrimming.None,
        TextTrimming.CharacterEllipsis,
        TextTrimming.WordEllipsis,
        TextTrimming.PrefixCharacterEllipsis,
        TextTrimming.LeadingCharacterEllipsis
    ];

    public List<FontWeight> FontWeights { get; } = [
        FontWeight.Thin,
        FontWeight.ExtraLight,
        FontWeight.UltraLight,
        FontWeight.Light,
        FontWeight.SemiLight,
        FontWeight.Normal,
        FontWeight.Regular,
        FontWeight.Medium,
        FontWeight.DemiBold,
        FontWeight.SemiBold,
        FontWeight.Bold,
        FontWeight.ExtraBold,
        FontWeight.UltraBold,
        FontWeight.Black,
        FontWeight.Heavy,
        FontWeight.ExtraBlack,
        FontWeight.UltraBlack
    ];

    public List<FontStyle> FontStyles { get; } = [
        FontStyle.Normal,
        FontStyle.Italic,
        FontStyle.Oblique
    ];
}
