using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio
{
    public class Account
    {
        public int numberAccount {  get; set; }
        // holder = titular
        public string holder { get; set; }

        public decimal bankroll { get; set; }

        public Account(int numberAccount, string holder, decimal bankroll)
        {
            this.numberAccount = numberAccount;
            this.holder = holder;
            this.bankroll = bankroll;
        }

        public void Retire(Account people, decimal value)
        {
            if(value < people.bankroll)
            {
                people.bankroll = people.bankroll - value;
            }
                

            
        }

        public void Deposit(Account people, decimal value)
        {
            people.bankroll += value;
        }
    }
}
