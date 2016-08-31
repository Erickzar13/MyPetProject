using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Prism.Mvvm;

namespace WpfApplication1.ViewModels
{
    class MainWindowViewModel : BindableBase
    {
        private int x = 1;
        private int y = 2;
        private int z = 3;

        public int X
        {
            get { return x; }
            set
            {
                SetProperty(ref x, value);

            }
        }

        public int Y
        {
            get { return y; }
            set
            {
                SetProperty(ref y, value);

            }
        }

        public int Z
        {
            get { return z; }
            set
            {
                SetProperty(ref z, value);
                
            }
        }

        public void Sum()
        {
            Z = X + Y;
        }
    }
}
