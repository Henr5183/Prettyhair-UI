using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prettyhair
{
    public class EMAIL
    {
        public void Subscribe(Order O)
        {
            O.OnOrder += new Order.OrderRecieved(Metode);
        }
        private void Metode(Order O, EventArgs e)
        {
            System.Console.WriteLine("Order Recieved");
        }

    }
}
