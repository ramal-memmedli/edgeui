using Avalonia;
using Avalonia.Controls;
using Avalonia.Themes.Fluent;
using EdgeUI.Gallery.Shell;

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .LogToTrace()
    .Start(AppMain, args);




static void AppMain(Application app, string[] args)
{
    var window = new GalleryMainWindow();
    window.Show();
    app.AttachDeveloperTools();

    app.Run(window);
}