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
            
        }
        {

            //Everthings like hunger, happiness and health is values on 10
            int Hunger = 5; 
            
            int Health = 5;
           
            int Happiness = 5;    
            //The above mentioned is the current status of the pet
            
            


            bool loop = true;
            while (loop)
            {

                //This is the main menu
                Console.WriteLine("\nMAIN MENU\n1. Feed the Pet\n2. Let the Pet play\n3. Let the Pet rest\n4. Check the current status\n5. EXIT\n\nChoose any option : ");

                int userinput2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("User input: " + userinput2); //Where we can enter the number corresponding to the selection that we have made

                switch (userinput2)
                {
                    case 1://When feeding the pet
                        Console.WriteLine();
                        Hunger = Hunger - 1; //When we feed the pet usually the hunger will get reduced by one and the health will claso get increased by one
                        Health = Health + 1;
                        Console.WriteLine("The Food was delicious, my hunger got reduced and health got increased.");
                        if (Hunger >= 8) //This is like warning when the limit is reached, when the limit is 8 or above it will leave a message like the pet is not hungry anymore or if it gets down it will also give a warning like the pet is about to die.
                            Console.WriteLine("Your pet is about die, give some food");
                        else if (Hunger <= 2)
                            Console.WriteLine("I am not much Hungry anymore, I want to play");
                        if (Hunger < 1 || Hunger > 10)
                        {
                            if (Hunger < 1) //These are the conditons in whcih the if the health, happiness and the Hunger gets above or below the threshold values
                            {
                                Hunger = 1;
                            }
                            
                        }
                        break;


                    case 2://When letting the pet play
                        Console.WriteLine();
                        Hunger = Hunger + 1; //When letting the pet play usually the hunger will be rised by one and the happiness will also get increased
                        Happiness = Happiness + 1;
                        Console.WriteLine("It was really good to play, I am very much happy and a bit hungry as well.");
                        if (Health >= 8) //When the health is greater than 8, there will be a message like it wants to play and as opposite when it falls down to 2 or below it will leave another messgae regarding the low health condition
                            Console.WriteLine("I am very healthy, I want to play");
                        else if (Health <= 2)
                            Console.WriteLine("You pet is about to die");
                        if (Hunger > 10) //These are the conditons in whcih the if the health, happiness and the Hunger gets above or below the threshold values
                        {
                            Hunger = 10;
                        }
                        if (Happiness > 10)
                        {
                            Happiness = 10;
                        }
                        break;

                    case 3://Let the pet rest
                        Console.WriteLine();
                        Hunger = Hunger + 1; //When the pet gets rest ususally the hungere will get increased , happiness will get decreased and the health will gets increased also
                        Happiness = Happiness - 1;
                        Health = Health + 1;
                        Console.WriteLine("It was nice to rest for a while, but I want to play.");
                        if (Happiness <= 3) //Ususally if the happiness gets lower than or equal to 3 it will also leave a message like the pet is about to get into the stage of depression
                            Console.WriteLine("Your pet is about to get depressed");
                        if (Happiness < 1) //These are the conditons in whcih the if the health, happiness and the Hunger gets above or below the threshold values
                        {
                            Happiness = 1;
                        }
                        if (Hunger > 10)
                        {
                            Hunger = 10;
                        }
                        if (Health > 10)
                        {
                            Health = 10;
                        }
                        break;

                    case 4: //Showing the current status of the pet
                        Console.WriteLine("This is my current status right now.......");
                        Console.WriteLine("\nHealth = " + Health);
                        Console.WriteLine("Hunger = " + Hunger);
                        Console.WriteLine("Happiness = " + Happiness);
                        
                        break;
                    case 5:// To exit from the loop
                        Console.WriteLine("Bye, Come back soon........");
                        loop = false;
                        break;

                   default: //This is a default statement like when we choose an input which is not in the list
                        Console.WriteLine("Emter a valid chioce: ");

                        break;
                      
                }




            }
        }



    }
}


    
    


