using System;

namespace II1302
{
    class Program
    {
        static void Main(string[] args)
        {

            var prompt = "Your choice (0: Stop): ";

            Console.WriteLine("Press 1 to record audio and translate");

            Console.Write(prompt);

            ConsoleKeyInfo x;
            do
            {
                x = Console.ReadKey();
                Console.WriteLine("");
                switch (x.Key)
                {
                    case ConsoleKey.D1:
                        APIInterface.RecognitionWithMicrophoneAsync().Wait();
                        break;
                }
            } while (x.Key != ConsoleKey.D0);
        }
    }
}
