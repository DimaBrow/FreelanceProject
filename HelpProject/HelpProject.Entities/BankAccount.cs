using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpProject.Entities
{
     public class BankAccount
    {
        public decimal Balance { get; set; }

        public int Bal_ID { get; set; }

        public string CreditCardNumber { get; set; }

        public string Bank { get; set; }

        public string CVV2 { get; set; }

        public DateTime ExpirationDate { get; set; }

        public string OwnerName { get; set; }

        public string OwnerLastName { get; set; }


        Evaluation AccountStateChagesResponse { get; set; }

        public BankAccount()
        {

        }

        public void AddToBalance()
        {

        }

        public void ShowBalance()
        {

        }

    }
}
