using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HelpProject.UI.Command
{
    public static class EmailValidation
    {
        public static bool IsValidMailAddress(string mailAddress)
        {
            try
            {
                return Regex.IsMatch(mailAddress, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            }
            catch
            {
                return false;
            }
        }

    }
}
