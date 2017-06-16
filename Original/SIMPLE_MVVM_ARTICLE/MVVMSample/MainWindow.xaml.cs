﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVMSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StudentListViewModel _studentListViewModel = new StudentListViewModel();

        public MainWindow()
        {
            InitializeComponent();

            MockServerProxy mockServerProxy = new MockServerProxy();


            _studentListViewModel.GetStudentsDelegate = mockServerProxy.GetStudents;
            _studentListViewModel.SaveStudentsDelegate = mockServerProxy.SaveStudents;

            this.DataContext = _studentListViewModel;
        }
    }
}
