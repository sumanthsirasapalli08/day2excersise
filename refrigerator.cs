using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace productmanagement
{
    class Refrigerator : product
    {
        int capacity;
        string bodymodel;
        string door;
        public void SetRefrigeratorData(int capacity, string bodymodel, string door)
        { 
            this.capacity = capacity;
            this.bodymodel = bodymodel;
            this.door = door;

        }
        internal void Display()
        {
            base.Display();
            Console.WriteLine($"capacity : {capacity} bodymodel : {bodymodel} door : {door}");

        }


        
    }
}
