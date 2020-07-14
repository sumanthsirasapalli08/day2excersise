using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productmanagement
{
    class Program
    {
        static void Main(string[] args)
        {
            product product = new product();
            product.SetProductData(1050, "xmse", "LG", 25000);
            Refrigerator refrigerator = new Refrigerator();
            refrigerator.SetRefrigeratorData(100, "Ron76", "twodoor");
            product.Display();
            refrigerator.Display();
            Console.ReadLine();

        }
    } 
}
