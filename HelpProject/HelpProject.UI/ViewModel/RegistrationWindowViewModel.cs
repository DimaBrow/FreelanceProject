using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HelpProject.Entities;
using HelpProject.BL;
using HelpProject.UI.Command;
using System.Windows;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace HelpProject.UI.ViewModel
{
    class RegistrationWindowViewModel : ViewModelBase
    {


        #region Fields



        #endregion


        #region Constructors

        public RegistrationWindowViewModel()
        {
            User = new User();

            //RegisterCommand = new Command.Command(arg => RegisterMethod());
        }


        #endregion


        #region Propetries

        public User User { get; set; }

        #endregion


        #region Commands


        public ICommand RegisterCommand { get; set; }


        #endregion


        #region Methods



        #endregion


        #region Private Methods

        /// <summary>
        /// registers a new user
        /// </summary>
        /*private void RegisterMethod()
        {
            var validEmail = EmailValidation.IsValidMailAddress(User.Login);

            if (validEmail == true)
            {
                if (User.Password != null)
                {
                    UserManager.CurrentUser = User;
                    UserManager.RegisterNewUser();
                    WindowManager.CloseWindow(WindowName.Registration);
                    WindowManager.OpenWindow(WindowName.FinalRegistration, WindowShowType.Show, 
                        new FinalRegistrationWindowViewModel());
                }
                else
                {
                    MessageBox.Show("Please enter password!");
                }
            }
            else
            {
                MessageBox.Show("Some fields are not filled. Fill in all fields correctly!");
            }
        }
        */
        #endregion
        }
}
