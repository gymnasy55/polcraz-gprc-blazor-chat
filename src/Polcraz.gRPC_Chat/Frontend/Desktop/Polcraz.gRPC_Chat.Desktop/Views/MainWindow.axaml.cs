using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Polcraz.gRPC_Chat.Desktop.Views
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
