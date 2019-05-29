using System;

namespace WedHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello You!");
            Console.WriteLine("From the following, what is your favorite Song?");
            Console.WriteLine("1. Nutshell, 2.Mr.Jones, 3.Have a Cigar");
            string song = Console.ReadLine();

            switch (song)
            {
                case "1":
                    listenNutshell();
                    break;

                case "2":
                    listenMJ(1);
                    break;

                case "3":
                    string favSong = listenGP(6);
                    Console.WriteLine(favSong);
                    break;
                default:
                    Console.WriteLine("Your favorite song is lame");
                    break;

            }


        }

        private static void listenNutshell()

        {
            Console.WriteLine("You chose Nutshell");
            Console.WriteLine("You listened to Nutshell");
        }

        private static void listenMJ(int ranking)

        {
            Console.WriteLine("You chose Mr.Jones");
            Console.WriteLine("You listened to Mr.Jones in {0}place", ranking);
        }

        private static string listenGP(int looper)

        {
            Console.WriteLine("You chose Gangstas Paradise");
            for (int i = 0; i < looper; i++)
            {
                listenMJ(i * 40);
            }
            return " Your songlist is over";
        }
    }
}

