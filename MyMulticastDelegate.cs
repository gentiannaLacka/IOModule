using System;

namespace IOModule
{
    public delegate void NumbersDelegate(int number1, int number2);
    class NumberOperation
    {
        public void AddNumbers(int number1, int number2)
        {
            Console.WriteLine("Sum is: " + number1 + number2);
        }
        public void DivideNumbers(int number1, int number2)
        {
            Console.WriteLine("Division is: " + number1 / number2);
        }
    }
}