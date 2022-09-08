using System.Windows.Input;
using ReactiveUI;

namespace AvaloniaSampleCompiledBinding.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        private string _message = String.Empty;
        
        public string Message
        {
            get => _message; 
            set => RaiseAndSetIfChanged(ref _message, value);
        }
        
        public ICommand HelloCommand { get; set; }

        public MainWindowViewModel()
        {
            HelloCommand = ReactiveCommand.Create(DoSomething);
        }

        private void DoSomething()
        {
            Message = "Hello World !";
        }
    }
}