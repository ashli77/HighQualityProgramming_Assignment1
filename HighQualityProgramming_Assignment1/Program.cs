// See https://aka.ms/new-console-template for more information
using System;
class pet
{
    static void Main()
    {
        Console.WriteLine("Choose a pet you like from below: \n1. Dog\n2. Cat\n3. Elephant"); //Choose the a pet you like
        Console.WriteLine("Choose the number corresponding to the Pet to choose your buddy");//Each pet is represented corresponding to a number as identity
        {
            int userinput = Convert.ToInt32(Console.ReadLine());//selection of pet corresponding to the number
            if (userinput == 1)
                Console.WriteLine("You have selected Dog as your pet");

            if (userinput == 2)
                Console.WriteLine("You have seleted Cat as your pet");

            if (userinput == 3)
                Console.WriteLine("You have selected Elephant as your pet");

            if (userinput >= 3)
                Console.WriteLine("Choose a valid number");


        }
        {
            Console.Write("Enter desired name for your buddy :");//choose a name for your pet
            string userinput1 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello " + userinput1);
            // Console.ReadLine();


        }
        {
            //Main Menu

            int Hunger = 5;
            
            int Health = 5;
           
            int Happiness = 5;
           
            


            bool loop = true;
            while (loop)
            {

                
                Console.WriteLine("\nMAIN MENU\n1. Feed the Pet\n2. Let the Pet play\n3. Let the Pet rest\n4. Check the current status\n5. EXIT\n\nChoose any option : ");

                int userinput2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("User input: " + userinput2);

                switch (userinput2)
                {
                    case 1:
                        Console.WriteLine();
                        Hunger = Hunger - 1;
                        Health = Health + 1;
                        Console.WriteLine("The Food was delicious, my hunger got reduced and health got increased.");
                        if (Hunger >= 8)
                            Console.WriteLine("Your pet is about die, give some food");
                        else if (Hunger <= 2)
                            Console.WriteLine("I am not much Hungry anymore, I want to play");
                        break;


                    case 2:
                        Console.WriteLine();
                        Hunger = Hunger + 1;
                        Happiness = Happiness + 1;
                        Console.WriteLine("It was really good to play, I am very much happy and a bit hungry as well.");
                        if (Health >= 8)
                            Console.WriteLine("I am very healthy, Iwant to play");
                        else if (Health <= 2)
                            Console.WriteLine("You pet is about to die");
                        break;

                    case 3:
                        Console.WriteLine();
                        Hunger = Hunger + 1;
                        Happiness = Happiness - 1;
                        Health = Health + 1;
                        Console.WriteLine("It was nice to rest for a while, but I want to play.");
                        if (Happiness <= 3)
                            Console.WriteLine("Your pet is about to get depressed");
                        break;

                    case 4:
                        Console.WriteLine("This is my current status right now.......");
                        Console.WriteLine("\nHealth = " + Health);
                        Console.WriteLine("Hunger = " + Hunger);
                        Console.WriteLine("Happiness = " + Happiness);
                        
                        break;
                    case 5:
                        Console.WriteLine("Bye, Come back soon........");
                        loop = false;
                        break;

                   default:
                        Console.WriteLine("Emter a valid chioce: ");

                        break;
                      
                }




            }
        }



    }
}


    
    


