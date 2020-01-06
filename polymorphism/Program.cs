using System;

namespace polymorphism 
{
    class ChangeMePlease { // Depending which data type is fed to this function, the resulting printMe() will be different.
                           // This is an example of polymorphism
        public void printMe(int number) {
            Console.WriteLine("I am polymorphic Rick: {0}", number);
        }
        public void printMe(string name) {
            Console.WriteLine("I am polymorphic Rick: {0}", name);
        }
        public void printMe(double doubleThing) {
            Console.WriteLine("I am polymorphic Rick: {0}", doubleThing);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ChangeMePlease poly = new ChangeMePlease();
            poly.printMe(10);
            poly.printMe("Rick");
            poly.printMe(10.05);
            Cheese: // Label names can only be used once but may have many 'gotos' pointing to them.
            Console.WriteLine("Hello World!");
            goto Cheese;
        }
    }
}
