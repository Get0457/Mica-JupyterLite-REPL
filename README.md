# Mica Browser Library

A .NET 6 WPF library that creates a basic Mica Window with WebView2.

## Features

Currently, there are limited features. However, we plan to implement more features later on.

- Create a Windows with DWM Backdrop (Default is Mica, but can choose Tabbed or Acrylic too!)
- Customizable Settings via Code (not yet through Settings Window)

Additionally, we worked on this but we're not sure if it works or not since we do not have the machine to test it.

- Windows 7 should have an aero effect on the background.

## Examples

```csharp
using System;
using System.Windows;
using MicaWindow;
using MicaBrowser;

var MicaBrowser = new MicaBrowser.MicaBrowser
{
    Customization =
    {
        // Customization is subject to change! We will add some examples later
    },
    Settings =
    {
        URI = new Uri("about:blank"), // about:blank has a transparent background!
        MicaWindowSettings =
        {
#if WINDOWS10_0_17763_0_OR_GREATER
            // Only avaliable with source built with net6-windows10.0.17763
            BackdropType = BackdropType.Mica, // Default: Mica. There are Regular, Mica, Acrylic, and Tabbed!
#endif
            ThemeColor = BackdropTheme.Dark   // Default: System Theme. There are Dark and Light theme!
        }
    }
};

MicaBrowser.Show();
```

## Future

There will be future implementations that help assist the development, including

- Settings Window
- More implementation to make the use of `MicaBrowser` class easier
- Multiple Tabs Browser

Outside the scope of this project, we plan to bring [Mica Discord](https://github.com/Get0457/Mica-Discord) to be based on this project instead. Additionally, we will create some projects based on this library.
