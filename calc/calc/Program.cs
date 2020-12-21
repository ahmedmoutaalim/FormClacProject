using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("taper premiere chiffre");
            string number1 = Console.ReadLine();
            int num1 = Convert.ToInt32(number1);

            Console.WriteLine("taper la douxieme chiffre");
            string number2 = Console.ReadLine();
            int num2 = Convert.ToInt32(number2);

            Console.WriteLine(" choisissez un application ");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("\tm - Multiply");
          

            string choix = Console.ReadLine();


            switch (choix) {

                case "a":

                Console.WriteLine($" c'est : { number1} + {number2} = " + (num1 + num2));
                    break;
                case "s":

                    Console.WriteLine($"c'est : {num1} - {num2} = " + (num1 - num2));
                    break;
                case "d":
                    Console.WriteLine($"c'est : {num1} / {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"c'est : {num1} * {num2} = " + (num1 * num2));
                    break;

            }
        }
    }
}
