using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiustoFarenheight
{
    class Program
    {
        static void Main(string[] args)
        {

            int faren;           
           


            Console.WriteLine("Enter the Temperature in Fahrenheit at 8:00Am ");
            faren = Convert.ToInt32(Console.ReadLine());
            calcTemp(faren);
           
            Console.WriteLine("Enter the Temperature in Fahrenheit at 12:00PM ");
            faren = Convert.ToInt32(Console.ReadLine());
            calcTemp(faren);

            Console.WriteLine("Enter the Temperature in Fahrenheit at 5:00PM ");
            faren = Convert.ToInt32(Console.ReadLine());
            calcTemp(faren);


        }
        public static void calcTemp(int faren) {
           int celsius = (faren - 32) * 5 / 9;
            if (celsius <= 0)
            {
                Console.WriteLine(celsius + " degrees C. It is freezing"); ;
            }
            if (celsius >= 37)
            {
                Console.WriteLine(celsius + " degrees C. It is hot outside.");
            }
            else
                Console.WriteLine(celsius);
        }
    }
}
