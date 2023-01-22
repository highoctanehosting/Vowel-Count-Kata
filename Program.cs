using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_Count_Kata
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Kata kata = new Kata();

            kata.GetVowelCount("abracadabra");

            kata.GetVowelCount("The quick brown fox jumps over the lazy dog");

            Stopwatch sw = new Stopwatch();

            sw.Start();
            while (sw.ElapsedMilliseconds < 20000)
            {

            }
            sw.Stop();
        }
    }
}