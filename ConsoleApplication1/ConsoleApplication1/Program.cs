using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> member = new List<string>();

            //member.Add("Peter");
            //member.Add("Jamie");
            //member.Add("Maggie");
            //member.Remove("Jamie");
            //member.RemoveAt("1");

            // 1.將所有號碼存入List中
            List<int> numbers = new List<int>();
            for (int i = 1; i<=42; i++)
            {
                numbers.Add(i);
            }
            // 2.隨機挑選一個印出
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                int r = rand.Next(1, numbers.Count);
                Console.WriteLine(numbers[r]);

                // 並從List中刪除
                numbers.RemoveAt(r);
            }
            Console.ReadLine();
        }
    }
}
