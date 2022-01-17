using System;

namespace ConsoleApp2
{
    class Program
    {
        //Polymorphism
        static void Main(string[] args)
        {
            AddMethod obj = new AddMethod();

            int addint=obj.Add(2, 3);
            Console.WriteLine("Addition of 2 integers " + addint);

            int addint3 = obj.Add(7, 8, 9);
            Console.WriteLine("Addition of 3 integers " + addint3);

            string string1 = obj.Add("Hello ", "World");
            Console.WriteLine("Addition of 2 strings is " + string1);

            decimal dec = 0;
            //decimal a1 = 5.67m;
            dec = Convert.ToDecimal(obj.Add(5.67m, 2.00m));
            Console.WriteLine("Addition of 2 deciamals " + dec);
                        
        }
    }
    public class AddMethod
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        public string Add(string s1, string s2)
        {
            return s1 + s2;
        }
    }
}
