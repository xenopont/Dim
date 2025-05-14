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
        // Set culture
        var culture = new CultureInfo("ru-RU"); // Replace with your desired culture (e.g., "de-DE", "en-US")

        Thread.CurrentThread.CurrentCulture = culture;
        Thread.CurrentThread.CurrentUICulture = culture;

        base.OnStartup(e);
    }
}