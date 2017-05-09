using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HelpProject.UI.ViewModel
{
    class WorkingAppWindowViewModel : ViewModelBase
    {


        #region Fields



        #endregion


        #region Constructors

        public WorkingAppWindowViewModel()
        {
            OpenMyProfileWindowCommand = new Command.Command(arg => OpenMyProfileWindow());
            OpenTicketsListCommand = new Command.Command(arg => OpenTicketsList());
        }

        #endregion


        #region Propetries


        #endregion


        #region Commands

        public ICommand OpenMyProfileWindowCommand { get; set; }
        public ICommand OpenTicketsListCommand { get; set; }



        #endregion


        #region Methods



        #endregion


        #region Private Methods

        /// <summary>
        /// opens my profile window
        /// </summary>
        private void OpenMyProfileWindow()
        {

        }

        /// <summary>
        /// shows all available tickets
        /// </summary>
        private void OpenTicketsList()
        {

        }

        #endregion
    }
}
