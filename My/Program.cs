using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mas = new List<string>();
            string[] source = { "a", "b", "d", "f", "f", "g", "g"};
            //string[] source = { "a", "a", "b", "b", "c", "c", "c", "d" };
            bool bol = true;
            string buf;
            for (int c = 0; c < source.Length-2; c++)
                for (int i = c+1; i < source.Length ; i++)
                for (int j = i+1; j < source.Length ; j++)
                {
                    buf = source[c] + source[i] + source[j];
                    if (!mas.Contains(buf))
                        mas.Add(buf);
                }
            foreach (string ab in mas)
                Console.WriteLine(ab);
            Console.WriteLine("Всего комбинаций "+mas.Count);
            Console.ReadLine();
        }
    }
}
