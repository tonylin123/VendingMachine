using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    interface IVending
    {

        void Purchase(int id);
        void ShowAll();
        void InsertMoney();
        Dictionary<int, int> EndTransaction();
        void ShowBasket();


    }
}
