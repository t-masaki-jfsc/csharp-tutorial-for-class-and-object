using System;
using System.Collections.Generic;
using System.Text;

namespace classes
{
    public class InterestEarningAccount : BankAccount
    {
        public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
        { }
    }
}