using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prettyhair
{
    public class Order
    {
        public event OrderRecieved OnOrder;
        public EventArgs e = null;
        public delegate void OrderRecieved(Order O, EventArgs e);
        
    




        int orderNr { get; set; }
        int orderDate { get; set; }
        int deliveryDate { get; set; }
        string picked { get; set; }


        private List<Orderline> Orderlinelist;
        public Order(int orderNr, int orderDate, int deliveryDate, string picked)
        {
            Orderlinelist = new List<Orderline>();
            this.orderNr = orderNr;
            this.orderDate = orderDate;
            this.deliveryDate = deliveryDate;
            this.picked = picked;

        }


        public void addware(Ware vare, int amount)
        {
            Orderline ordrelinje = new Orderline();
            ordrelinje.Quantity = amount;
        }


        public void OrderRecieve()
        {
            if (OnOrder != null)
            {
                OnOrder(this, e);
            }
        }

        //Method
        //AddWare(Ware, Amount)
    }
}
