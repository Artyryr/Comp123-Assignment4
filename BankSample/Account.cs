using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BankSample
{
    [XmlInclude(typeof(CheckingAccount))]
    [XmlInclude(typeof(SavingAccount))]
    [Serializable]
    public abstract class Account
    {
        public double Balance = 0;
        public string AccountNumber;
        public List<double> Transactions { get; set; }
        public Account(string accountNumber)
        {
            AccountNumber = accountNumber;
        }
        public Account() { }
        public void Debit(double amount)
        {
            Balance = Balance - amount;
        }
        public void Deposit(double amount)
        {
            Balance = Balance + amount;
        }
        //public string GetType()
        //{
        //    SavingAccount.
        //}
    }
}
