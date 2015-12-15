using System.Windows;
using GUI.ViewModel;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            MainViewModel vm = new MainViewModel();
            DataContext = vm;
            InitializeComponent();            
        }
    }
}