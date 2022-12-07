
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delwgates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> Add = new Action<int, int>(Addition);
            Action<int, int> Sub = new Action<int, int>(Subraction);
            Action<int, int> Multi = new Action<int, int>(Mutiplication);
            Action<int, int> Div = new Action<int, int>(Division);

            calculatorAction(Add += Sub += Multi += Div);



            Console.ReadLine();
        }
        static void Addition(int FirstNumber, int SecondNumber)
        {
            Console.WriteLine("Addition is : " + (FirstNumber + SecondNumber));
        }
        static void Subraction(int FirstNumber, int SecondNumber)
        {
            Console.WriteLine("Subraction is : " + (FirstNumber - SecondNumber));
        }
        static void Mutiplication(int FirstNumber, int SecondNumber)
        {
            Console.WriteLine("Mutiplication is : " + (FirstNumber * SecondNumber));
        }
        static void Division(int FirstNumber, int SecondNumber)
        {
            Console.WriteLine("Division is : " + (FirstNumber / SecondNumber));
        }

        static void calculatorAction(Action<int, int> call)
        {
            call(20, 5);
        }
    }
}

