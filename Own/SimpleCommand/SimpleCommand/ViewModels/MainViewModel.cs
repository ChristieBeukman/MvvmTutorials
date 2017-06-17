using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apex.MVVM;
using System.Windows;

namespace SimpleCommand.ViewModels
{
    public class MainViewModel : ViewModel
    {
        public MainViewModel()
        {
            simpleCommand = new Command(DoSimpleCommannd);
        }

        private void DoSimpleCommannd()
        {
            MessageBox.Show("simple");
        }

        private Command simpleCommand;

        public Command SimpleCommand
        {
            get
            {
                return simpleCommand;
            }

        }
    }
}
