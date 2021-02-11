using System;

namespace IOModule
{
    class Program
    {
        static void Main(string[] args)
        {
            //test myExtensionMethods
            string s = "Ana";
            int i = s.NumberOfVowels();
            bool palindrome = s.IsPalindrome();

            Console.WriteLine("Is it palindrome? "+ palindrome +", How many vowels? "+ i);

            //instantiate the generic class we specify the type 
            MyGenericClass<int> myGenericClass= new MyGenericClass<int>();

            //test MymulticastDelegate
            NumberOperation numberOperation= new NumberOperation();
            //bind first method to the delegate 
            NumbersDelegate numbersDelegate= new NumbersDelegate(numberOperation.AddNumbers);
            numbersDelegate += numberOperation.DivideNumbers;
            //invoke the delegate
            numbersDelegate(3,4);
            //in case of removing a metho from the delegate
            numbersDelegate-=numberOperation.DivideNumbers;



            // Printer printer = new Printer();
            // printer.DoJob();

            // Scanner scanner = new Scanner();
            // scanner.DoJob();

            // Scale scale = new Scale();
            // scale.DoJob();
        }
    }
}
