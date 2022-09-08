using System.Diagnostics;
using Avalonia;
using Avalonia.Controls;
using Microsoft.Extensions.DependencyInjection;
using Avalonia.Controls.ApplicationLifetimes;
using AvaloniaSampleCompiledBinding.ViewModels;


namespace AvaloniaSample.Controls;

public class ViewModelLocator
{
    public static IServiceProvider ServiceProvider;

    private T GetViewModel<T>() where T : ViewModelBase
    {
        var viewModel = ServiceProvider.GetRequiredService<T>();
        return viewModel;
    }

    private static ViewModelLocator _viewModelLocator;
    public static ViewModelLocator Current
    {
        get
        {
            try
            {
                if(_viewModelLocator == null && Application.Current.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime)
                    _viewModelLocator = Application.Current.FindResource("ViewModelLocator") as ViewModelLocator;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);  
            }

            return _viewModelLocator;
        }
    }
    
    public MainWindowViewModel MainWindowViewModel => GetViewModel<MainWindowViewModel>();

}