using System;

namespace SpirvSpecToJson
{
    internal class SpecsLocator
    {
        public static string FindUrlOrDefault(string[] args, string optionName, string defaultURL)
        {
            int size = args.Length;
            for(int i = 0; i < size; i++)
            {
                if (i == size - 1)
                    continue;
                string currentString = args[i];
                if(currentString.Equals(optionName))
                {
                    return args[i + 1];
                }
            }
            Console.WriteLine("No url for "+optionName+", using default: "+defaultURL);
            return defaultURL;
        }
    }
}