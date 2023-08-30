using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan3
{
    class Account
    {
        private long accountNumber;
        private string name;
        private double balance;
        private double RATE = 0.035;

        public long AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

    }
}
