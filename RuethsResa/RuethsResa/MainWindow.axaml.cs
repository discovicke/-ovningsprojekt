using Avalonia.Controls;

namespace RuethsResa;

public partial class MainWindow : Window
{
    
    public MainWindow()
    {
        InitializeComponent();
        Title = "Rueths Resa";
        Width = 735;
        Height = 690;
        CanResize = true;
        WindowState = WindowState.Normal;
        SizeToContent = SizeToContent.Manual;
        DataContext = new MainViewModel();
        

    }
}