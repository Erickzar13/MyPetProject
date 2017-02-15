using System.Windows;

using FontsMaster.ViewModel;

namespace FontsMaster
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new ApplicationViewModel();
        }
    }
}
