using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace FontsMaster.ViewModel
{
   public class ApplicationViewModel
    {
        public FontFamily SelectedFontFamily { get; set; }

        public List<FontFamily> AllFontFamilies { get; set; }

        public BindingList<FontFamily> SelectedFontFamilies { get; set; }

        public int FontSize { get; set; }

        public bool IsInverted { get; set; }

        public ApplicationViewModel()
       {
           AllFontFamilies = Fonts.SystemFontFamilies.ToList();

            SelectedFontFamilies = new BindingList<FontFamily>();
        }


        private RelayCommand printCommand;

        public RelayCommand PrintCommand
        {
            get
            {
                return printCommand ??
                       (printCommand = new RelayCommand(obj =>
                                                        {
                                                            var run = obj as InkCanvas;
                                                            var printDialog = new PrintDialog();
                                                            if (printDialog.ShowDialog() == true)
                                                            {
                                                                printDialog.PrintVisual(run, "Print");
                                                            }
                                                        },obj => obj is InkCanvas));
            }
        }


        private RelayCommand moveToSelectedRelayCommand;

        public RelayCommand MoveToSelectedRelayCommand
       {
           get
           {
               return moveToSelectedRelayCommand ??
                      (moveToSelectedRelayCommand = new RelayCommand(obj =>
                                                                     {
                                                                         SelectedFontFamilies.Add(
                                                                                                  obj as
                                                                                                      FontFamily);
                                                                     },
                                                                     obj => !SelectedFontFamilies.Contains(obj as
                                                                                                      FontFamily)));
           }
       }

        private RelayCommand removeFromSelectedCommand;

        public RelayCommand RemoveFromSelectedCommand
        {
            get
            {
                return removeFromSelectedCommand ?? (removeFromSelectedCommand = new RelayCommand(obj =>
                                                                                                  {
                                                                                                      SelectedFontFamilies.Remove(obj as FontFamily);
                                                                                                  },obj => SelectedFontFamilies.Contains((FontFamily)obj)));
            }
        }
    }
}
