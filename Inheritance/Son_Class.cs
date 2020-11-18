using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Son_Class: Dad_Class
    {
        private string sonsName = "Tyke";
        public void PrintNames()
        {   
            Console.WriteLine("Printing Dads name through inheritance");
            this.PrintDadsName();
            Console.WriteLine($"Printing sons name from own class {this.sonsName}");
        }
    }
}
