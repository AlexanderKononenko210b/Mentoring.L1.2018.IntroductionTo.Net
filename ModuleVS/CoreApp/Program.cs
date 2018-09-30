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
                if (args == null)
                {
                    throw new NullReferenceException("Input argument is null");
                }

                if (args.Length == 0 || args.Length > 1)
                {
                    throw new ArgumentOutOfRangeException($"Incorrect parameter {nameof(args)}");
                }

                OutputGreeting(args[0]);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
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
