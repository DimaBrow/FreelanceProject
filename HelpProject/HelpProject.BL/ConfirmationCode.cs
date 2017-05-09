using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;

namespace HelpProject.BL
{
    public static class ConfirmationCode
    {
        #region Public methods

        /// <summary>
        /// Sends an e-mail to user with the confirmation code
        /// </summary>
        /// <param name="mailAdress">receiver's email</param>
        public static void SendVerificationMail(string mailAdress)
        {
            MailAddress from = new MailAddress("mail.helpproject@gmail.com", "Help Project");
            MailAddress to = new MailAddress(mailAdress);

            MailMessage message = new MailMessage(from, to);
            message.Subject = "Verification code";
            message.Body = "<h2><p><DIV ALIGN=\"Center\">Hello!!!</DIV><p><p>Your confirmation code is: <b><u>" + 
                GenerateCode() + "</u></b><p>Thanks for choosing Help Project!!!";
            message.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("mail.helpproject@gmail.com", "HelpProject2017");
            smtp.EnableSsl = true;
            smtp.Send(message);
        }


        #endregion


        #region Private methods


        /// <summary>
        /// generates random 8-digit code
        /// </summary>
        /// <returns>random 8-digit code</returns>
        private static string GenerateCode()
        {
            const string codeCharsEn = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string codeCharNumeric = "0123456789";
            const int codeLenght = 8;

            ArrayList charGroups = new ArrayList();
            charGroups.Add(codeCharsEn.ToCharArray());
            charGroups.Add(codeCharNumeric.ToCharArray());

            byte[] randomBytes = new byte[4];
            int[] charsLeftInGroup = new int[charGroups.Count];

            for (int i = 0; i < charsLeftInGroup.Length; i++)
                charsLeftInGroup[i] = ((char[])charGroups[i]).Length;

            int[] leftGroupOrder = new int[charGroups.Count];

            for (int i = 0; i < leftGroupOrder.Length; i++)
                leftGroupOrder[i] = i;


            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(randomBytes);

            int seed = (randomBytes[0] & 0x7f) << 24 |
                randomBytes[1] << 16 |
                randomBytes[2] << 8 |
                randomBytes[3];

            Random random = new Random(seed);

            char[] code = null;

            code = new char[codeLenght];

            int nextCharIdx;
            int nextGroupIdx;
            int nextLeftGroupOrderIdx;
            int lastCharIdx;
            int lastLeftGroupOrderIdx = leftGroupOrder.Length - 1;

            for (int i = 0; i < code.Length; i++)
            {
                if (lastLeftGroupOrderIdx == 0)
                    nextLeftGroupOrderIdx = 0;
                else
                    nextLeftGroupOrderIdx = random.Next(0, lastLeftGroupOrderIdx);

                nextGroupIdx = leftGroupOrder[nextLeftGroupOrderIdx];
                lastCharIdx = charsLeftInGroup[nextGroupIdx] - 1;

                if (lastCharIdx == 0)
                    nextCharIdx = 0;
                else
                    nextCharIdx = random.Next(0, lastCharIdx + 1);

                code[i] = ((char[])charGroups[nextGroupIdx])[nextCharIdx];

                if (lastCharIdx == 0)
                    charsLeftInGroup[nextGroupIdx] = ((char[])charGroups[nextGroupIdx]).Length;
                else
                {
                    if (lastCharIdx != nextCharIdx)
                    {
                        char temp = ((char[])charGroups[nextGroupIdx])[lastCharIdx];
                        ((char[])charGroups[nextGroupIdx])[lastCharIdx] = ((char[])charGroups[nextGroupIdx])[nextCharIdx];
                        ((char[])charGroups[nextGroupIdx])[nextCharIdx] = temp;
                    }
                    charsLeftInGroup[nextGroupIdx]--;
                }

                if (lastLeftGroupOrderIdx == 0)
                    lastLeftGroupOrderIdx = leftGroupOrder.Length - 1;
                else
                {
                    if (lastLeftGroupOrderIdx != nextLeftGroupOrderIdx)
                    {
                        int temp = leftGroupOrder[lastLeftGroupOrderIdx];
                        leftGroupOrder[lastLeftGroupOrderIdx] = leftGroupOrder[nextLeftGroupOrderIdx];
                        leftGroupOrder[nextLeftGroupOrderIdx] = temp;
                    }
                    lastLeftGroupOrderIdx--;
                }

            }
            return (new string(code));

        }


        #endregion
    }
}
