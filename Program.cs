using System;
namespace solution
{
    class assignment
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "Poly ilaro ";

            Console.Write("Enter second Integer: ");
            int new_int = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second double: ");
            double new_double = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second string: ");
            string new_str = Console.ReadLine();

            Console.WriteLine(i + new_int);
            Console.WriteLine(d + new_double);
            Console.WriteLine(s + new_str);

        }

    }
}



