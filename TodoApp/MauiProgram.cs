using Microsoft.Extensions.Logging;
using TodoApp.Services;
using TodoApp.ViewModels;
using TodoApp.Views;

namespace TodoApp;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<ITodoItemService, TodoItemService>();

        builder.Services.AddSingleton<ItemsPageViewModel>();
        builder.Services.AddSingleton<ItemsPage>();

        builder.Services.AddTransient<ItemDetailViewModel>();   // new code
        builder.Services.AddTransient<DetailsPage>();           // new code

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
