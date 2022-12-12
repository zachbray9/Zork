using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZorkBuilderWPF.ViewModels;

namespace ZorkBuilderWPF.Commands
{
    class SaveAsCommand : CommandBase
    {
        private ZorkBuilderViewModel ZorkBuilderViewModel;
        public SaveAsCommand(ZorkBuilderViewModel zorkBuilderViewModel)
        {
            ZorkBuilderViewModel = zorkBuilderViewModel;
        }

        public override void Execute(object parameter)
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
