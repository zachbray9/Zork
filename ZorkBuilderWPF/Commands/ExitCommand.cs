using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ZorkBuilderWPF.ViewModels;

namespace ZorkBuilderWPF.Commands
{
    class ExitCommand : CommandBase
    {
        private ZorkBuilderViewModel ZorkBuilderViewModel;
        public ExitCommand(ZorkBuilderViewModel zorkBuilderViewModel)
        {
            ZorkBuilderViewModel = zorkBuilderViewModel;
        }
        public override void Execute(object parameter)
        {

            if (ZorkBuilderViewModel.ChangesWereMade == true)
            {
                MessageBoxResult messageBoxResult = MessageBox.Show("Do you want to save your changes?", "Changes have been made without saving", MessageBoxButton.YesNoCancel, MessageBoxImage.Exclamation);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    if (ZorkBuilderViewModel.FilePath != null)
                    {
                        ZorkBuilderViewModel.SaveGame();
                    }
                    else
                    {
                        SaveFileDialog saveFileDialogue = new SaveFileDialog()
                        {
                            Filter = "JSON files (*.json)|*.json",
                            DefaultExt = ".json"

                        };

                        if (saveFileDialogue.ShowDialog() == true)
                        {
                            ZorkBuilderViewModel.FilePath = saveFileDialogue.FileName;
                            ZorkBuilderViewModel.FileName = Path.GetFileName(ZorkBuilderViewModel.FilePath);
                            ZorkBuilderViewModel.SaveGame();
                        }
                    }
                    Application.Current.Shutdown();
                }
                else if(messageBoxResult == MessageBoxResult.No)
                {
                    Application.Current.Shutdown();
                }
                else
                {
                    return;
                }
            }
            else
            {
                Application.Current.Shutdown();
            }
        }
    }
}
