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
            parameterCommand = new Command(DoParameterCommand);
            enableDisableCommand = new Command(
                      () =>
                      {
                          MessageBox.Show("Enable/Disable command called.");
                      }, false);
            eventsCommand = new Command(
         () =>
         {
             MessageBox.Show("Calling the Events Command.");
         });
        }
        #region SImple Command
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

        #endregion

        #region Parameter COmmand

        private void DoParameterCommand(object parameter)
        {
            MessageBox.Show("Parameter is " + parameter.ToString());
        }


        private Command parameterCommand;

        public Command ParameterCommand
        {
            get
            {
                return parameterCommand;
            }

        }

     
        #endregion

        #region  EnableDisable COmmand

        private void DisableCOmmand()
        {
            EnableDisableCommand.CanExecute = false;
        }

        private void EnableCommand()
        {
            EnableDisableCommand.CanExecute = true;
        }

        private Command enableDisableCommand;

        public Command EnableDisableCommand
        {
            get
            {
                return enableDisableCommand;
            }


        }

        #endregion

        #region eVENTfIRECommand

        private Command eventsCommand;

        public Command EventsCommand
        {
            get
            {
                return eventsCommand;
            }

           
        }

        #endregion
    }
}
