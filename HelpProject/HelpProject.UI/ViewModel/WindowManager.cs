﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xaml;
using HelpProject.UI;



namespace HelpProject.UI.ViewModel
{
    public static class WindowManager
    {
        public static LoginWindow Login { get; set; }
        public static RegistrationWindow Registration { get; set; }
        public static FinalRegistrationWindow FinalRegistration { get; set; }


        #region Open Window Method

        public static void OpenWindow(WindowName windowName, WindowShowType windowShowType, object viewModel)
        {
            switch (windowName)
            {
                case WindowName.Login:
                    if (Login == null)
                    {
                        Login = new LoginWindow
                        {
                            DataContext = (LoginWindowViewModel) viewModel
                        };
                        ShowWindow(windowShowType, Login);
                    }
                    break;
                case WindowName.Registration:
                    if (Registration == null)
                    {
                        Registration = new RegistrationWindow
                        {
                            DataContext = (RegistrationWindowViewModel) viewModel

                        };
                        ShowWindow(windowShowType, Registration);
                    }
                    break;
                case WindowName.FinalRegistration:
                    if (FinalRegistration == null)
                    {
                        FinalRegistration = new FinalRegistrationWindow
                        {
                            DataContext = (FinalRegistrationWindowViewModel)viewModel

                        };
                        ShowWindow(windowShowType, FinalRegistration);
                    }
                    break;
            }
        }

        #endregion

        #region Show Window Method

        static void ShowWindow(WindowShowType windowShowType, Window window)
        {
            switch (windowShowType)
            {
                case WindowShowType.Show:
                    window.Show();
                    break;

                case WindowShowType.ShowDialog:
                    window.ShowDialog();
                    break;
            }
        }

        #endregion 

        #region Close Window Method

        public static void CloseWindow(WindowName windowName)
        {
            switch (windowName)
            {
                case WindowName.Login:
                    if (Login != null)
                    {
                        Login.Close();
                        Login = null;
                    }
                    break;
                case WindowName.Registration:
                    if (Registration != null)
                    {
                        Registration.Close();
                        Registration = null;
                    }
                    break;
        
            }
        }

      #endregion
    }
}
