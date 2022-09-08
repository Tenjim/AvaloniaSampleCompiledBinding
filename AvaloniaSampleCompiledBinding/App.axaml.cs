using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaSample.Controls;
using AvaloniaSampleCompiledBinding.ViewModels;
using AvaloniaSampleCompiledBinding.Views;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaSampleCompiledBinding
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
            
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<MainWindowViewModel>();
            ViewModelLocator.ServiceProvider = serviceCollection.BuildServiceProvider();
            
            
            
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow();
            }
         
        }
    }
}