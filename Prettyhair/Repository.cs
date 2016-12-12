using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prettyhair
{
    public class Repository
    {
        public List<Ware> Wareliste { get; set; }
        public List<Order> Orderliste { get; set; }
        public Repository()
        {
            Wareliste = new List<Ware>(); 
            Orderliste = new List<Order>();
        }
        public Ware FindWare(int WareNR)
        {
            Ware warefundet = null;
            int nr = 0;
            bool fundet = false;

            while (fundet = false && nr < Wareliste.Count)
            {
                if (Wareliste[nr].wareNr == WareNR)
                {
                    warefundet = Wareliste[nr];
                    fundet = true;
                }
                nr = nr + 1;

            }
            return warefundet;
        }

            //Properties
            //OrderList
            //WareList

            //Method
            //AddWare
            //AddOrder
            //RemoveWare
            //RemoveOrder
            //AdjustOrder(Price, Amount)
            //AdjustWare(Price, Amount, Description)
        }
    }
