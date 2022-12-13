using Microsoft.Win32;
using System;
using System.IO;
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
                    Environment.Exit(0);
                }
                else if(messageBoxResult == MessageBoxResult.No)
                {
                    Environment.Exit(0);
                }
                else
                {
                    return;
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
