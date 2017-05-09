using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using HelpProject.UI.ViewModel;


namespace HelpProject.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var loginWindow = new WorkingAppWindow()
            {
                DataContext = new WorkingAppWindowViewModel()
            };
            loginWindow.Show();
        }
    }
}
