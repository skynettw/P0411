using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P0411
{
    class Car
    {
        private string Color;
        private string Brand;
        private string Model;

        public Car(string b, string m, string c)
        {
            Brand = b;
            Model = m;
            Color = c;
        }
        public void ShowMe()
        {
            Console.WriteLine("{0}:{1}, Color:{2}",
                Brand, Model, Color);
        }
        public void ChangeColor(string c)
        {
            Color = c;
        }
    }
}
