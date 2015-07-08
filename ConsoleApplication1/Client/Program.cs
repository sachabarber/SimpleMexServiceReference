using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ServiceReference1;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceReference1.SimpleServiceClient proxy = new SimpleServiceClient();
            var x = proxy.DoWork(10);
            Console.ReadLine();
        }
    }
}
