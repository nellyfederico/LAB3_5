using System;

namespace LAB3_5SpamChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string blackListWord = "pills";
            bool isSpam = false;
            string message = Console.ReadLine();
            if (message.Contains(blackListWord))
            {
                isSpam = true;
                Console.WriteLine("This email is spam and it has been sent to the Spam Folder!");
            }
            else
            {
                isSpam = false;
                Console.WriteLine("This email is not spam.");
            }
        }
    }
}
