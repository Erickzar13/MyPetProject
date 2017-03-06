using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;

using FontsMaster.Models;

using Microsoft.Win32;

namespace FontsMaster.ViewModel
{
    public class ApplicationViewModel
    {
        public FontFamily SelectedFontFamily { get; set; }

        public BindingList<FontFamily> AllFontFamilies { get; set; }

        public BindingList<FontFamily> SelectedFontFamilies { get; set; }

        public int FontSize { get; set; }

        public bool IsInverted { get; set; }

        public ApplicationViewModel()
        {
            AllFontFamilies = new BindingList<FontFamily>();

            SelectedFontFamilies = new BindingList<FontFamily>(FontWrapper.FromXML());
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
                                                        },
                                                        obj => obj is InkCanvas));
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
                                                                                                      SelectedFontFamilies.Remove(
                                                                                                                                  obj as
                                                                                                                                      FontFamily);
                                                                                                  },
                                                                                                  obj =>
                                                                                                      SelectedFontFamilies.Contains(
                                                                                                                                    (
                                                                                                                                    FontFamily
                                                                                                                                    )obj)));
            }
        }

        private RelayCommand saveCommand;

        public RelayCommand SaveCommand
        {
            get
            {
                return saveCommand ?? (saveCommand = new RelayCommand(obj =>
                {
                    FontWrapper.ToXML((IEnumerable<FontFamily>)obj);
                }));
            }
        }

        private RelayCommand openFolderCommand;

        public RelayCommand OpenRelayCommand
        {
            get
            {
                return openFolderCommand ?? (openFolderCommand = new RelayCommand(t =>
                {
                    var openFileDialog = new OpenFileDialog();
                    openFileDialog.Multiselect = true;
                    if (openFileDialog.ShowDialog() == true)
                    {
                        var fonts = new PrivateFontCollection();

                        foreach (var font in openFileDialog.FileNames)
                        {
                            fonts.AddFontFile(font);

                        }

                        foreach (System.Drawing.FontFamily fontsFamily in fonts.Families)
                        {
                            AllFontFamilies.Add(new FontFamily(fontsFamily.Name));
                        }
                    }
                }));
            }
        }

        private RelayCommand clearCommand;

        public RelayCommand ClearCommand
        {
            get
            {
                return clearCommand ?? (clearCommand = new RelayCommand(obj =>
                {
                   AllFontFamilies.Clear();
                }));
            }
        }
    }
}
