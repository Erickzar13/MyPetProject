using System.IO;
using System.Windows;

using FontsMaster.ViewModel;

namespace FontsMaster
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            if (!File.Exists(@"..\Fonts.xml"))
            {
                File.Create(@"..\Fonts.xml").Close();
            }

            InitializeComponent();

            DataContext = new ApplicationViewModel();
        }
    }
}
