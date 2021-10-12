using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace QueuingCashier
{


    class CashierClass
    {
        private int x = 10000;
        public static string getNumberInQueue = "";
        public static Queue<string> CashierQueue = new Queue<string>();



        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber;
        }

    }
}
