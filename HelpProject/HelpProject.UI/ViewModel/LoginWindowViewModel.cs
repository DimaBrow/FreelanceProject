using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using HelpProject.BL;
using HelpProject.Entities;
using HelpProject.UI.Command;


namespace HelpProject.UI.ViewModel
{
    class LoginWindowViewModel : ViewModelBase
    { 


        #region Fields



        #endregion


        #region Constructors

        public LoginWindowViewModel()
        {

            RegisterCommands = new Command.Command(arg => RegisterMethod());

            ForgotPasswordCommand = new Command.Command(arg => ForgotPasswordMethod());

            User = new User()
            {
                Login = "Nigga",
                Password = "111"
            };

            LogInCommand = new Command.Command(arg => LoginMethod());
            User = new User();
        }

        

        #endregion


        #region Propetries

        public User User { get; set; }

        #endregion


        #region Commands

        public ICommand LogInCommand { get; set; }
        public ICommand RegisterCommands { get; set; }
        public ICommand ForgotPasswordCommand { get; set; }



        #endregion


        #region Methods



        #endregion


        #region Private Methods
        /// <summary>
        /// log in a new user
        /// </summary>
        private void LoginMethod()
        {
            //throw new NotImplementedException();

            MessageBox.Show("Login ok");

        }

        private void RegisterMethod()
        {
            var newUser = User;


            var registrationWindow = new RegistrationWindow
            {
                DataContext = new RegistrationWindowViewModel()
            };
            registrationWindow.Show();

        }

        private void ForgotPasswordMethod()
        {
            var ForgotUser = User;

            var forgotPassWindow = new ForgotPasswordWindow()
            {
                DataContext = new ForgotPasswordWindowViewModel()
            };
            forgotPassWindow.Show();
            var validEmail = EmailValidation.IsValidMailAddress(User.Login);

            if (validEmail == true)
            {
                if (User.Password != null)
                {
                    UserManager.CurrentUser = User;
                    UserManager.LoginUser();
                    WindowManager.CloseWindow(WindowName.Login);
                    WindowManager.OpenWindow(WindowName.WorkingApp, WindowShowType.Show, new WorkingAppWindowViewModel());
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

        #endregion
    }
}

