using System;
using System.Collections.Generic;
using System.Text;

namespace classes
{
    class GetCardAccount : BankAccount
    {
        private decimal _monthlyDeposit = 0m;

        public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0) : base(name, initialBalance)
            => _monthlyDeposit = monthlyDeposit;

        public override void PerformMonthEndTransactions()
        {
            if (_monthlyDeposit != 0)
            {
                MakeDeposit(_
                    , DateTime.Now, "Add monthly deposit");
            }
        }
    }
}