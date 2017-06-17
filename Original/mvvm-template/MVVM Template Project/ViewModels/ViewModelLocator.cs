/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocatorTemplate xmlns:vm="clr-namespace:MVVM_Template_Project.ViewModels"
                                   x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
*/

using GalaSoft.MvvmLight;
//using GalaSoft.MvvmLight.Ioc;
//using Microsoft.Practices.ServiceLocation;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using MVVM_Template_Project.Models;

namespace MVVM_Template_Project.ViewModels
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if (ViewModelBase.IsInDesignModeStatic)
            {
                SimpleIoc.Default.Register<IDataService, Design.DesignDataService>();
            }
            else
            {
                SimpleIoc.Default.Register<IDataService, DataService>();
            }

           
            SimpleIoc.Default.Register<Main_ViewModel>                 () ;
            SimpleIoc.Default.Register<MvvmLight_ViewModel>            () ;
            SimpleIoc.Default.Register<Random_ViewModel>               () ;
            SimpleIoc.Default.Register<About_ViewModel>                () ;
            SimpleIoc.Default.Register<ValidationsConvertes_ViewModel> () ;
        }

        /// <summary>
        /// Gets the Main property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public Main_ViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<Main_ViewModel>();
            }
        }


        public Random_ViewModel Random_VM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<Random_ViewModel>();
            }
        }

        public MvvmLight_ViewModel MvvmLight_VM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MvvmLight_ViewModel>();
            }
        }

        public About_ViewModel About_VM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<About_ViewModel>();
            }
        }

        public ValidationsConvertes_ViewModel ValAndCon_VM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ValidationsConvertes_ViewModel>();
            }
        }

        /// <summary>
        /// Cleans up all the resources.
        /// </summary>
        public static void Cleanup()
        {
        }
    }
}