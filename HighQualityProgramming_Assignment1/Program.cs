// See https://aka.ms/new-console-template for more information
using System;
class pet{
    static void Main()
    {
        Console.WriteLine("Choose a pet you like from below: \n1. Dog\n2. Cat\n3. Elephant");
        Console.WriteLine("Choose the number corresponding to the Pet to choose your buddy");
        {
            int userinput = Convert.ToInt32(Console.ReadLine());
            if (userinput == 1)
                Console.WriteLine("You have selected Dog as your pet");
            if (userinput == 2)
                Console.WriteLine("You have seleted Cat as your pet");
            if (userinput == 3)
                Console.WriteLine("You have selected Elephant as your pet");

        }
    }   

}