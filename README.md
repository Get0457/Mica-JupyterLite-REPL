# Mica JupyterLite REPL

Mica JupyterLite REPL is [JupyterLite](https://github.com/jupyterlite/jupyterlite) REPL in a WebView2 browser with Mica as background. (yeah, that's it!)

## WARNING: STILL IN BETA

This project is still in Beta. You can expect to see some CSS errors if you use it now.

## Screenshots

Light mode

![Light Mode Demo](https://media.discordapp.net/attachments/954814845792952390/975068933948313690/unknown.png)

Dark mode (see "How to enable dark mode?" section below)

![Dark Mode Demo](https://media.discordapp.net/attachments/954814845792952390/975068934254526524/unknown.png)

## How to install it?

First, please download and install Evergreen WebView2 and .NET 6 Desktop Runtime if you haven't already

- [Evergreen](https://developer.microsoft.com/en-us/microsoft-edge/webview2/#download-section)
- [.NET 6 Desktop Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

Then, go to the release page, download it, and double click setup.exe

Visit [Mica Browser Library](https://github.com/gets-mica-project/Mica-Browser-Library) to see the library repository this project is based on

## How to enable dark mode?

Unfortunately, because the dev is ~lazy~ I mean busy, it is not possible to change the theme directly yet! Fortunately, there is a workaround for it.

1. Press Ctrl + Shift + I to open Developer Tools
2. Copy `window.location = "https://jupyterlite/_output/index.html"` and paste it into the Console tab
3. Navigate through Settings -> JupyterLab Dark on the web page
4. Go back to Developer Tools -> Copy `window.location = "https://jupyterlite/_output/repl/index.html"` and paste it into the Console tab
5. Enjoy Dark Mode!

## Future

Although I did not plan to put a lot of time into this project, these are something I would do if I put more time in.

1. Custom URL: Meaning that it does not only have to use JupyterLite
2. Easier way to customize dark/light theme
