using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpressionDemo
{
    //define delegate
    public delegate string GreetingDelegate(string str);
    internal class LamdaExpresClass
    {
        public static string Greetings(string name)
        {
            return "Hello " + name + ", Welcome!";
        }
        static void Main()
        {
            //instantiation of delegate
            GreetingDelegate dg = new GreetingDelegate(Greetings);

            string s = dg.Invoke("Neha");
            Console.WriteLine(s);

            Console.WriteLine("\n\nLamda Expression :\n");
            //lamda expression
            GreetingDelegate dg1 = (name) =>
            {
                return "Hello " + name + ", Welcome!";
            };
            string s1 = dg1.Invoke("Pranita");
            Console.WriteLine(s1);


            Console.ReadLine();


        }
    }
}
