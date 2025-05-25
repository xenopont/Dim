using System.Windows;
using System.Windows.Media;

namespace Dim.UI.Windows;

public class OverlappedWindow : Window
{
    protected OverlappedWindow()
    {
        WindowStyle = WindowStyle.None;
        AllowsTransparency = true;
        Background = new SolidColorBrush(Colors.Transparent);
    }

    private void ApplyStyles()
    {
        Style = Application.Current.FindResource("OverlappedWindowStyle") as Style;
    }

    public override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        ApplyStyles();
    }
}