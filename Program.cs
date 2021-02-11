using System;

namespace IOModule
{
    class Program
    {
        static void Main(string[] args)
        {
            //test IOModule
            IOModule module = new IOModule();

            var printer = new Printer(module);
            var scanner = new Scanner(module);
            var scale = new Scale(module);

            // Call the method that raises the event.
            module.Start();

            //test myExtensionMethods
            string s = "Ana";
            int i = s.NumberOfVowels();
            bool palindrome = s.IsPalindrome();

            Console.WriteLine("Is it palindrome? " + palindrome + ", How many vowels? " + i);

            //instantiate the generic class we specify the type 
            MyGenericClass<int> myGenericClass = new MyGenericClass<int>();

            //test MymulticastDelegate
            NumberOperation numberOperation = new NumberOperation();
            //bind method to the delegate 
            NumbersDelegate numbersDelegate = new NumbersDelegate(numberOperation.AddNumbers);
            numbersDelegate += numberOperation.DivideNumbers;
            //invoke the delegate
            numbersDelegate(3, 4);
            //in case of removing a method from the delegate
            numbersDelegate -= numberOperation.DivideNumbers;
        }
    }
}
