// See https://aka.ms/new-console-template for more information
using System;
class pet
{
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
        {
            Console.Write("Enter desired name for your buddy :");
            string userInput1 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello " + userInput1);
            // Console.ReadLine();


        }
        {
            //Main Menu
            //Console.WriteLine("MAIN MENU");
            //Console.WriteLine("1. Feed the Pet");
            //Console.WriteLine("2. Let the Pet play");
            //Console.WriteLine("3. Let the Pet rest");
            //Console.WriteLine("4. Check the current status");
            //Console.WriteLine("5. EXIT");
            //Console.WriteLine("\nChoose any option : ");

            int Hunger = 10;
            int Health = 10;
            int Happiness = 10;



            //int userinput2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("User input: " + userinput2);
            bool loop = true;
            while (loop)
            {

                
                Console.WriteLine("\nMAIN MENU");
                Console.WriteLine("1. Feed the Pet");
                Console.WriteLine("2. Let the Pet play");
                Console.WriteLine("3. Let the Pet rest");
                Console.WriteLine("4. Check the current status");
                Console.WriteLine("5. EXIT");
                Console.WriteLine("\nChoose any option : ");

                int userinput2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("User input: " + userinput2);

                switch (userinput2)
                {
                    case 1:
                        Console.WriteLine();
                        Hunger = Hunger - 1;
                        Health = Health + 1;
                        Console.WriteLine("The Food was delicious, my hunger got reduced and health got increased");
                        break;


                    case 2:
                        Console.WriteLine();
                        Hunger = Hunger + 1;
                        Happiness = Happiness + 1;
                        break;

                    case 3:
                        Console.WriteLine();
                        Hunger = Hunger + 1;
                        Happiness = Happiness + 1;
                        Health = Health + 1;
                        break;

                    case 4:
                        Console.WriteLine("\nHealth = " + Health);
                        Console.WriteLine("Hunger = " + Hunger);
                        Console.WriteLine("Happiness = " + Happiness);
                        break;
                    case 5:
                        Console.WriteLine("bye");
                        loop = false;
                        break;

                   default:
                        Console.WriteLine("emter a valid chioce: ");

                        break;
                      
                }




            }
        }



    }
}


    
    


