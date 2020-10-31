using System;
using System.Linq;

namespace FindNuofZeros
{
    public class Program
    {
        static void Main(string[] args)
        {
            string givenNumber = "23000494002999400";
            var res = givenNumber.ToCharArray().ToList();
            Console.WriteLine(res.Where(x => x.Equals('0')).Select(x => x).Count());
            Console.ReadLine();
        }
    }
}
