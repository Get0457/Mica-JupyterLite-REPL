using System;
using System.Windows;
using MicaWindow;
using MicaBrowser;
namespace MicaBroswerTester;

public partial class App : Application
{
    public App()
    {
        var MicaBrowser = new MicaBrowser.MicaBrowser
        {
            Customization =
            {
                
            },
            Settings =
            {
                MicaWindowSettings =
                {
#if WINDOWS10_0_17763_0_OR_GREATER
                    BackdropType = BackdropType.Mica, // Default: Mica. There are Regular, Mica, Acrylic, and Tabbed!
#endif
                    ThemeColor = BackdropTheme.Dark   // Default: System Theme. There are Dark and Light theme!
                },
                URI = new Uri("about:blank") // about:blank has a transparent background!
            }
        };
        MainWindow = MicaBrowser;
        MainWindow.Show();
    }
}
