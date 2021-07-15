using System;
using System.Collections.Generic;
using System.Text;

namespace classes
{
    class LineOfCreditAccount : BankAccount
    {
        public override void PerformMonthEndTransactions()
        {
            if (Balance < 0)
            {
                // Negete the balance to get a positive interesr charge:
                var interest = Balance * 0.07m;
                MakeWithdrawal(interest, DateTime.Now, "Charge monthlu interest");
            }
        }
    }
}