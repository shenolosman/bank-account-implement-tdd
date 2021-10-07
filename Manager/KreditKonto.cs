﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class KreditKonto : BankKonto
    {
        //Kreditkonto som tillåter kredit över en viss gräns
        public KreditKonto(int balance) : base(balance)
        {
        }

        public override bool CanTakeOutMoney(int amount)
        {
            bool takeOutMoney = amount <= Balance;

            if (takeOutMoney)
            {
                Balance -= amount;
            }

            return takeOutMoney;
        }
    }
}
