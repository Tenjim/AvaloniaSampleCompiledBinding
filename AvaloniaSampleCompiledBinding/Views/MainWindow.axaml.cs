using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using AvaloniaSample.Controls;
using AvaloniaSampleCompiledBinding.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaSampleCompiledBinding.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools(KeyGesture.Parse("Ctrl+Shift+F12"));
#endif
            // TODO remarks: only workaround about compiledbinding with my ViewModelLocator
            var viewmodel = ViewModelLocator.ServiceProvider.GetRequiredService<MainWindowViewModel>();
            DataContext = viewmodel;
            
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}