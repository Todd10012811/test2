using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
           

        {

            var input = "";
            int input2;
            int input3;
            int output;
            int input4;
            int input5;
            Console.WriteLine("hello please tyep youre name");
            input = Console.ReadLine();
            Console.WriteLine("Hello " + input);

            Console.WriteLine("please enter a Number");
            input2 = int.Parse(Console.ReadLine());
            Console.Write("please enter aother Number");
            input3 = int.Parse(Console.ReadLine());
            output = input2 + input3;
            Console.WriteLine("{0} +{1} {2}",input2,input3, output);
            Console.ReadLine();

            Console.WriteLine("please enter a Number between 1 and 12");
            input4 = int.Parse(Console.ReadLine());
            for (int i = 0; i < 12; i++)
            { Console.WriteLine("{0} x {1} = {2}", input4, i,(input4 * i)); };
            Console.ReadLine();

            Console.WriteLine("please enter youre shcool grade");
            input5 = int.Parse(Console.ReadLine());
            if (input5 < 50) { Console.WriteLine("you failed"); }
            else if (input5 > 50) { Console.WriteLine("you passed"); }
            Console.ReadLine();


            string[] classmates = new string[5];
            for (int i = 0; i <= 4; i++) {
                Console.WriteLine("enter a name");
                classmates[i] = Console.ReadLine();
            }
            Console.ReadLine();

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(classmates [i]);
               
            }
            Console.ReadLine();
        }
    }
}
