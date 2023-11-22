using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_account
{
    abstract class abstract_class_account
    {
        public int actno;
        public int bal = 1000;
        public abstract string deposit(int a, int b);
        public abstract string withdraw(int a, int b);
        public string showbalance()
        {
            return "bal is=" + bal;

        }
    }
    class saving : abstract_class_account
    {
        public override string deposit(int a, int b)
        {
            int interest = 500;
            bal = bal + b + interest;
            actno = a;
            return "result:" + bal;
        }
        public override string withdraw(int a, int b)
        {
            int interest = 500;
            bal = bal - b - interest;
            actno = a;
            return "result:" + bal;
        }
    }
    class current : abstract_class_account
    {
        public override string deposit(int a, int b)
        {
            bal = bal + b;
            return "bal is" + bal;
        }
        public override string withdraw(int a, int b)
        {
            bal = bal - b;
            return "bal is" + bal;

        }

    }
}
