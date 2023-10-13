using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Practic_FileStreamSerialize
{
    public class test
    {
        public int number;

        public test(int n)
        {
            number = n;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"C:\Users\Admin\source\repos\HW_Sharp_12\Two.json";
            string path2 = @"C:\Users\Admin\source\repos\HW_Sharp_12\notTwo.json";
            int toTwo = 0;
            int notTwo = 0;
            Random rand = new Random();
            test a = new test(rand.Next());
            StreamWriter TWO = new StreamWriter(path1, true);
            StreamWriter NOT = new StreamWriter(path2, true);
            for (int i = 0; i < 100000; i++)
            {
                a.number = rand.Next();
                if (a.number % 2 == 0)
                {
                    TWO.WriteLine(a.number);
                    toTwo++;
                }
                else
                {
                    NOT.WriteLine(a.number);
                    notTwo++;
                }
            }
            TWO.Close();
            NOT.Close();
            Console.WriteLine($"n % 2 == 0: {toTwo}\nn % 2 != 0: {notTwo}");
        }
    }
}
