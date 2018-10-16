using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MorseEncoder.Encoder("Hello World"));

            
        }
        
    }

    public class MorseEncoder
    {
        public static string Encoder(string message)
        {
            Dictionary<char, string> morseDict = new Dictionary<char, string>
            {
                { '!', "...---..." },
                { '.', "-.-.--" },
                { 'A', ".-.-.-" },
                { 'B', ".-" },
                { 'C', "-..." },
                { 'D', "-.-." },
                { 'E', "-.." },
                { 'F', "..-." },
                { 'G', "--." },
                { 'H', "...." },
                { 'I', ".." },
                { 'J', ".---" },
                { 'K', "-.-" },
                { 'L', ".-.." },
                { 'M', "--" },
                { 'N', "-." },
                { 'O', "---" },
                { 'P', ".--." },
                { 'Q', "--.-" },
                { 'R', ".-." },
                { 'S', "..." },
                { 'T', "-" },
                { 'U', "..-" },
                { 'V', "...-" },
                { 'W', ".--" },
                { 'X', "-..-" },
                { 'Y', "-.--" },
                { 'Z', "--.." }
            };

            string result = "";
            message = message.ToUpper();
            
            char[] toEncode = message.ToCharArray();
            for(int i = 0; i < toEncode.Length; i++)
            {
                if (morseDict.ContainsKey(toEncode[i]) == true)
                {
                    result += " " + morseDict[toEncode[i]];
                }
                else result += "  ";
            }

            return result.Trim();
            
            

            
        }
    }
}
