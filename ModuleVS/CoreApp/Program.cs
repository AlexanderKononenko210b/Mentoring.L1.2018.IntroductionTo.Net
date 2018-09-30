using System;
using ModuleStandart;

namespace CoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0 || args.Length > 1)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(args)}");
                }

                OutputGreeting(args[0]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// The output greeting.
        /// </summary>
        private static void OutputGreeting(string name)
        {
            var result = Greeting.GetGreeting(name);
            Console.WriteLine(result);
        }
    }
}
