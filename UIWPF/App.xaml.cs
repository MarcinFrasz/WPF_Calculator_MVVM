using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using UIWPF.Services;
using UIWPF.Stores;
using UIWPF.ViewModels;

namespace UIWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore;
        private readonly NavigationViewModel _navigationViewModel;
        public App()
        {
            _navigationStore = new NavigationStore();
            _navigationViewModel = new NavigationViewModel(_navigationStore,CreateCalculatorNavigationService(),CreateConverterNavigationService());
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new CalculatorViewModel(_navigationViewModel);
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
        private NavigationService<CalculatorViewModel> CreateCalculatorNavigationService()
        {
            return new NavigationService<CalculatorViewModel>(
                _navigationStore,
                () => new CalculatorViewModel(_navigationViewModel));
        }
        private NavigationService<ConverterViewModel> CreateConverterNavigationService()
        {
            return new NavigationService<ConverterViewModel>(
                _navigationStore,
                () => new ConverterViewModel(_navigationViewModel));
        }

    }
}
