using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Apex.MVVM;

namespace SimpleCommand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ViewModel.EventsCommand.Executing +=
                new Apex.MVVM.CancelCommandEventHandler(EventsCommand_Executing);
            ViewModel.EventsCommand.Executed +=
          new Apex.MVVM.CommandEventHandler(EventsCommand_Executed);
        }

        void EventsCommand_Executed(object sender, Apex.MVVM.CommandEventArgs args)
        {
            MessageBox.Show(("The command has finished - this is the View speaking!"));
        }

        void EventsCommand_Executing(object sender, Apex.MVVM.CancelCommandEventArgs args)
        {
            if (MessageBox.Show("Cancel the command?",
                     "Cancel?",
                     MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                args.Cancel = true;
        }
    }
}
