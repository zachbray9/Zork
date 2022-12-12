﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ZorkBuilderWPF.Commands
{
    class ExitCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            //
            //Will add something to make sure the file is saved before exiting
            //
            Application.Current.Shutdown();
        }
    }
}
