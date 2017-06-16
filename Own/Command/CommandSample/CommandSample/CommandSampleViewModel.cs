using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CommandSample
{
    public class CommandSampleViewModel
    {
        public RelayCommand theCommand { get; private set; }

        public CommandSampleViewModel()
        {
            theCommand = new RelayCommand(OnExecute, CanExecute);
        }

        bool CanExecute(object parameter)
        {
            return true;
        }

        void OnExecute()
        {
            MessageBox.Show("Command Executed");
        }
    }
}
