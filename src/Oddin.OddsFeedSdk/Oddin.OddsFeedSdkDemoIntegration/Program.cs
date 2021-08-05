using System;
using System.Threading.Tasks;

namespace Oddin.OddsFeedSdkDemoIntegration
{
    class Program
    {
        // Put you token here:
        internal const string TOKEN = "1a0c5a30-74ed-416d-b120-8c05f92e382f";

        static async Task Main(string[] _)
        {
            Console.WriteLine("Select example:");
            Console.WriteLine("G = General");
            Console.WriteLine("R = Replay");
            Console.Write("Enter letter: ");
            var key = Console.ReadKey().KeyChar;

            switch (char.ToUpper(key))
            {
                case 'R':
                {
                    await ReplayExample.Run();
                    break;
                }
                default:
                {
                    await GeneralExample.Run();
                    break;
                }
            }
        }
    }
}
