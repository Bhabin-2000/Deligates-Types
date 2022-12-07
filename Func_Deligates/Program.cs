using System;

namespace Func_Deligates
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Func<int, int, int> adding = new Func<int, int, int>(Add);
            Console.WriteLine(adding.Invoke(25,25));
            Func<int, int, int> Subracting = new Func<int, int, int>(Sub);
            Console.WriteLine(Subracting.Invoke(25, 25));
            Func<int, int, int> Mutiplicating = new Func<int, int, int>(Mul);
            Console.WriteLine(Mutiplicating.Invoke(25, 25));
            Func<int, int, int> Division = new Func<int, int, int>(Div);
            Console.WriteLine(Division.Invoke(25, 25));

            Console.ReadKey();
        }
         static int Add(int num1,int num2)
        {
            return num1 + num2;
        }
        static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        static int Div(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
