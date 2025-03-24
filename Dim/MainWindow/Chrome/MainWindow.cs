using System.Windows;

namespace Dim.MainWindow;

public partial class MainWindow
{
    private void CloseButtonOnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void MaximizeButtonOnClick(object sender, RoutedEventArgs e)
    {
        WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
    }

    private void MinimizeButtonOnClick(object sender, RoutedEventArgs e)
    {
        WindowState = WindowState.Minimized;
    }
}