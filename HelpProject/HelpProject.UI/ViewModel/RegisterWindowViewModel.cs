using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HelpProject.Entities;

namespace HelpProject.UI.ViewModel
{
    class RegisterWindowViewModel : ViewModelBase
    {


        #region Fields



        #endregion


        #region Constructors

        public RegisterWindowViewModel()
        {
            User = new User();

            RegisterCommand = new Command.Command(arg => RegisterMethod());
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
        /// tries to find user in DB if exists trow exeption else 
        /// register a new user and open log in window
        /// </summary>
        private void RegisterMethod()
        {

        }

        #endregion
    }
}
