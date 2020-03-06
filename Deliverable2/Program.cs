using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int checksum = 0;
            string input = "";
            string message = "";

            Console.WriteLine("Input your message.");
            input = Console.ReadLine().ToUpper();

            foreach (char letter in input)
            {
                string messageLetter = (letter - 64).ToString();
                message += messageLetter + "-";
                checksum += letter;
            }

            Console.WriteLine($"Encoded message is {message}");
            Console.WriteLine($"Message checksum is {checksum}");
            Console.ReadLine();
        }
    }
}
