using System;

namespace ShifrChes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Шифровка 2-Дешифровка");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите строку");
            string inputString = Console.ReadLine();          
            bool deshifr=false;
            switch (choice)
            {
                case 1:
                    deshifr = false;
                    break;
                case 2:
                    deshifr = true;
                    break;
                case 3:
                    CryptoAnalys(inputString);
                    break;
            }
            Console.WriteLine(GenerateShifrCesacer(inputString,deshifr));
            //Console.WriteLine(ShifrVishenera(inputString , deshifr));
            Console.ReadKey();
        }
        static string GenerateShifrCesacer(string inputString,bool deshifr)
        {
            Console.WriteLine("Введите сдвиг");
            int shift = Convert.ToInt32(Console.ReadLine());
            if (deshifr)
            {
                shift = -shift;
            }
            string output = "";
            for (int counter = 0 ; counter<inputString.Length ; counter++)
            {
                output += Convert.ToChar(inputString[counter]+shift);
            }
            return output;
        }
        static string ShifrVishenera(string inputString,bool deshifr)
        {
            Console.WriteLine("Введите ключ");           
            string keyString= Console.ReadLine();
            int[] keyElements = new int[keyString.Length];
            for (int counter = 0 ; counter<keyElements.Length ; counter++)
            { 
                keyElements[counter] = Convert.ToInt32(Convert.ToString(keyString[counter]));
                if (deshifr)
                {
                    keyElements[counter] = -keyElements[counter];
                }
            }            
            string output = "";
            for (int counter = 0 ,keyCounter=0; counter<inputString.Length ; counter++,keyCounter++)
            {
                output += Convert.ToChar(inputString[counter]+keyElements[keyCounter]);
                if (keyCounter == keyElements.Length-1) keyCounter=-1;
            }
            return output;
        }
        static void CryptoAnalys(string inputString)
        {

            string output;
            for (int counter=1 ; counter<36 ; counter++)
            {
                output = "";
                for (int count = 0 ; count<inputString.Length ; count++)
                {
                    output += Convert.ToChar(inputString[count]-counter);
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(output);
            }
        }
    }
}
