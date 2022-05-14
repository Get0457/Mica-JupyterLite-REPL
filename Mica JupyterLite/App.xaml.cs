extern alias WV2;
using System;
using System.Windows;
using MicaWindow;
using MicaBrowser;
using WV2::Microsoft.Web.WebView2.Core;
using System.Threading.Tasks;

namespace MicaJupyterLite;

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
                PreferedTitle = "Mica JupyterLite",
                MicaWindowSettings =
                {
#if WINDOWS10_0_17763_0_OR_GREATER
                    BackdropType = BackdropType.Mica, // Default: Mica. There are Regular, Mica, Acrylic, and Tabbed!
#endif
                    ThemeColor = BackdropTheme.Dark   // Default: System Theme. There are Dark and Light theme!
                }
            }
        };
        var WebView2 = MicaBrowser.WebView2;
        WebView2.CoreWebView2InitializationCompleted += delegate
        {
            WebView2.CoreWebView2.SetVirtualHostNameToFolderMapping("jupyterlite",
            "./JupyterLite", CoreWebView2HostResourceAccessKind.Allow);
            WebView2.Source = new Uri("https://jupyterlite/_output/repl/index.html");
            WebView2.NavigationCompleted += async delegate
            {
                string theme = "null";
                while (theme == "null")
                {
                    await Task.Delay(100);
                    theme = await WebView2.CoreWebView2.ExecuteScriptAsync("document.body.getAttribute('data-jp-theme-name')");
                }
                switch (theme)
                {
                    case "\"JupyterLab Light\"":
                        MicaBrowser.ThemeColor = BackdropTheme.Light;
                        break;
                    case "\"JupyterLab Dark\"":
                        MicaBrowser.ThemeColor = BackdropTheme.Dark;
                        break;
                }
            };
        };
        MainWindow = MicaBrowser;
        MainWindow.Show();
    }
}
