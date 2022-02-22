using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _2022._02._22
{
    class Program
    {
        static void Main(string[] args)
        {

            string szoveg = File.ReadAllText("input.txt");
            string mentes = szoveg.Replace(",", "");
            string mentes2 = mentes.Replace(".", "");
            string mentes3 = mentes2.Replace("?", "");

            string[] szótömb = mentes3.Split(' ');
            Dictionary<string, int> szótár = new Dictionary<string, int>();
            
            foreach (string szó in szótömb)
            {
                if (szótár.ContainsKey(szó))
                {
                    szótár[szó] += 1;
                }
                else
                {
                    szótár[szó] = 1;
                }
            }
            foreach (string kulcs in szótár.Keys)
            {
                Console.WriteLine($"{kulcs}:{szótár[kulcs]} db");
            }
        }
    }
}
