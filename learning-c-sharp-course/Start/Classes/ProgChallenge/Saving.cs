using System;
// Interest rate decimal

// First three withdrawals are free then $2 for each 

// Not allowed to go into overdraft

namespace Bank
{
    class SavingsAcct : BankAccount
    {
        private int _withdrawcount = 0;
        private const decimal WITHDRAW_CHARGE = 2.0m;
        private const int WITHDRAW_LIMIT = 3;

        public SavingsAcct(string fname, string lname, decimal interest, decimal initial)
            : base(fname, lname, initial)
        {
            InterestRate = interest;
        }

        public decimal InterestRate
        {
            get; set;
        }

        public void ApplyInterest()
        {
            Balance += (Balance * InterestRate);
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Sorry you cannot overdraw from a Savings Account");
            }
            else
            {
                base.Withdraw(amount);

                _withdrawcount++;

                if (_withdrawcount > WITHDRAW_LIMIT)
                {
                    Console.WriteLine($"More than 3 withdrawals - Extra charge of {WITHDRAW_CHARGE}");
                    base.Withdraw(WITHDRAW_CHARGE);
                }
            }

        }




    }

}