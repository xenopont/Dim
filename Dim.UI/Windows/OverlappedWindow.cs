using System.Windows;
using System.Windows.Media;

namespace Dim.UI.Windows;

public class OverlappedWindow : Window
{
    private void ApplyStyles()
    {
        if (Application.Current.TryFindResource("MySolidColorBrush") is SolidColorBrush brush) Background = brush;
    }

    public override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        ApplyStyles();
    }
}