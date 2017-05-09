using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HelpProject.UI.ViewModel
{
    class MyProfileWindowViewModel : ViewModelBase
    {
        #region Fields

        #endregion

        #region Constructors

        public MyProfileWindowViewModel()
        {
            ShowConversationListCommand = new Command.Command(arg => ShowConversationList());
            ShowYourTicketsListCommand = new Command.Command(arg => ShowYourTicketsList());
            ShowGeneralInfoCommand = new Command.Command(arg => ShowGeneralInfo());
        }

        #endregion

        #region Properties

        #endregion

        #region Commands

        public ICommand ShowConversationListCommand { get; set; }
        public ICommand ShowYourTicketsListCommand { get; set; }
        public ICommand ShowGeneralInfoCommand { get; set; }

        #endregion

        #region Methods

        #endregion

        #region Private Methods



        /// <summary>
        /// show list of user conversations
        /// </summary>
        private void ShowConversationList()
        {

        }

        /// <summary>
        /// shows all tickets, user was taken part
        /// </summary>
        private void ShowYourTicketsList()
        {

        }

        /// <summary>
        /// show user information (e-mail, bank account, etc)
        /// </summary>
        private void ShowGeneralInfo()
        {

        }

        #endregion


    }
}
