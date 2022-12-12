using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Zork.Common;
using ZorkBuilderWPF.ViewModels;
using Microsoft.Win32;

namespace ZorkBuilderWPF.Commands
{
    class SaveCommand : CommandBase
    {
        private ZorkBuilderViewModel ZorkBuilderViewModel;
        public SaveCommand(ZorkBuilderViewModel zorkBuilderViewModel)
        {
            ZorkBuilderViewModel = zorkBuilderViewModel;
        }

        public override void Execute(object parameter)
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
            
        }
    }
}
