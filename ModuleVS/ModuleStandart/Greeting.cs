using System;

namespace ModuleStandart
{
    /// <summary>
    /// The greeting class.
    /// </summary>
    public static class Greeting
    {
        /// <summary>
        /// Get greeting with input name.
        /// </summary>
        /// <param name="name">input name</param>
        /// <returns>The greeting string</returns>
        public static string GetGreeting(string name)
        {
            if (name == null)
            {
                throw new NullReferenceException("Enter correct name!");
            }

            return $"{DateTime.Now.TimeOfDay} Hello {name}";
        }
    }
}
