using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HelpProject.Entities;
using HelpProject.UI.Command;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace HelpProject.UI.ViewModel
{
    class ForgotPasswordWindowViewModel : ViewModelBase
    {


        #region Fields



        #endregion


        #region Constructors

        public ForgotPasswordWindowViewModel()
        {
            ChangePasswordCommand = new Command.Command(arg => ChangePassword());
        }

       

        #endregion


        #region Propetries
        public User User { get; set; }

        #endregion


        #region Commands

        public ICommand ChangePasswordCommand { get; set; }

        #endregion


        #region Methods




        #endregion


        #region Private Methods

        /// <summary>
        /// changes password
        /// </summary>
        private void ChangePassword()
        {

        }

        #endregion
    }
}

