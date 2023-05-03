namespace UnoApp.Wasm;

public class Program
{
    private static App? _app;

    public static int Main(string[] args)
    {
        // Added to reproduce compatibility issue with Blazor and Microsof.JSInterop:
        _ = Microsoft.AspNetCore.Components.WebAssembly.Hosting.WebAssemblyHostBuilder.CreateDefault();

        Microsoft.UI.Xaml.Application.Start(_ => _app = new AppHead());

        return 0;
    }
}
