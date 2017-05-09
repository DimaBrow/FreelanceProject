using HelpProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using HelpProject.DAL;
using System.Windows.Forms;

namespace HelpProject.BL
{
    public static class UserManager
    {
        public static User CurrentUser { get; set; }

        /// <summary>
        /// register current user
        /// </summary>
        public static void RegisterNewUser()
        {
            try
            {
                if (!UserRepository.RegisterNewUser(CurrentUser))
                {
                    throw new Exception("Can't register. User with login " + CurrentUser.Login
                                        + " had already redistered.");
                }
                ConfirmationCode.SendVerificationMail(CurrentUser.Login);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// login current user
        /// </summary>
        public static void LoginUser()
        {
            try
            {
                if (!UserRepository.LoginUser(CurrentUser))
                {
                    throw new Exception("Can't login. There is no user with login " + CurrentUser.Login);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
    }
}
