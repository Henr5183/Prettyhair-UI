using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prettyhair;

namespace Prettyhair_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Program nyProgram = new Program();
            nyProgram.Run();
        }
        public void Run()
        {
            Order O = new Order(5,05122016,08122016,"Cykel");
            EMAIL e = new EMAIL();
            e.Subscribe(O);
            O.OrderRecieve();
            Console.ReadLine();
        }
    }
}
