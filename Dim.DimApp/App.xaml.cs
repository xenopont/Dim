using System.Globalization;
using System.Windows;

namespace Dim.DimApp;

/// <summary>
///     Interaction logic for App.xaml
/// </summary>
public partial class App
{
    protected override void OnStartup(StartupEventArgs e)
    {
        // The actual culture code should come from user settings
        // (not implemented yet)
        var culture = new CultureInfo("en-US");

        Thread.CurrentThread.CurrentCulture = culture;
        Thread.CurrentThread.CurrentUICulture = culture;

        base.OnStartup(e);
    }
}