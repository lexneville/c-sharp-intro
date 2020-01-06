using System;
// Link this to a simple import...
// can have multiple - just be careful that you import the right things
// if you don't use something, comment out, or remove it

namespace FirstProject
// collection of classes - play about with temoving it to see what the errors show, use undo!
{
    class Program
    {
        static void Main(string[] args)
        {
            NewFile SomethingForNow = new NewFile();
            string myName;
            SomethingForNow.setName("Hello");
            myName = SomethingForNow.getName();
            Console.WriteLine(myName);
            // Console.WriteLine("Hello World!");
            // Console.ReadKey();
            // Console.ReadLine();

            // int age, yourAge, myAge;
            // int age = 55, yourAge = 66; // Single line declarations save a little processing time.
            // yourAge = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(age);
            // int bothAddedTogether = age + yourAge;
            // Console.WriteLine(age + yourAge);
            // Console.WriteLine(bothAddedTogether);

            string[] favouritePlacesToGo;
            favouritePlacesToGo = new string[2] {"Code Nation", "Nowhere else"};
            Console.WriteLine(favouritePlacesToGo[1]);

            string[] leastFavouritePlacesToGo = new string[] {"North Coders", "Hell"};

            
        }
    }
}
