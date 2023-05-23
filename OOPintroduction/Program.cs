// See https://aka.ms/new-console-template for more information
using OOPintroduction;

bool signUp =true;
Console.WriteLine("Hello, Welcome to our Gym!\n");

Console.WriteLine("We need You to give Us information for you membership.");
Console.WriteLine("Lets begin.");


do
{
    DateTime dateJoined=DateTime.Now.Date;
    DateTime renewalDate = dateJoined.AddDays(30);
    Console.WriteLine("Your name: ");
    string name = Console.ReadLine();
    Console.WriteLine("\nPlease select a number from list so we can apply a discount if possible:");
    Console.WriteLine("1. Student\n2.Multisport\n3.Regular\n");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            {
                Console.WriteLine("Type in your college name: ");
                string college=Console.ReadLine();
                StudentMembership studentMembership = new StudentMembership(30);
                studentMembership.College = college;
                studentMembership.DateJoined = dateJoined;
                studentMembership.Name = name;
                studentMembership.RenewalDate = renewalDate.Date;
                Console.WriteLine("Your total price is: {0}\n",studentMembership.CalculateMembershipPrice());
                signUp = false;
            }
            break;
        case 2:
            {
                Console.WriteLine();
                MultisportMembership multisportMembership = new MultisportMembership(30);
                multisportMembership.DateJoined = dateJoined;
                multisportMembership.Name = name;
                multisportMembership.RenewalDate = renewalDate.Date;
                Console.WriteLine("Your total Price is: {0}\n", multisportMembership.CalculateMembershipPrice());
                signUp = false;
            }
            break;
        case 3:
            {
                Membership membership = new Membership(30);
                membership.DateJoined = dateJoined;
                membership.Name = name;
                membership.RenewalDate = renewalDate.Date;
                Console.WriteLine("Your total price is: {0}\n", membership.CalculateMembershipPrice());
                signUp = false;
            }
            break;
    }
} while (signUp);

Console.WriteLine("\nSignup successful!\n");

bool workoutSelected = false;

while (workoutSelected != true)
{
    Console.WriteLine("Select 1 for crossfit or 2 for powerilfting: ");
    int workoutChoice = Convert.ToInt32(Console.ReadLine());

    if (workoutChoice == 1)
    {
        Crossfitter crossfitter = new Crossfitter();
        crossfitter.PerformAWorkout();
        workoutSelected = true;
    }
    else if (workoutChoice == 2)
    {
        Powerlifter powerlifter = new Powerlifter();
        powerlifter.PerformAWorkout();
        workoutSelected = true;
    }
    else
    {
        Console.WriteLine("Wrong input! Try again\n");
    }
}

Console.WriteLine("Hey, wait a few moments until I finish my training session and then I can help you get started!\n");
Trainer trainer = new Trainer();
trainer.PerformTrainingSession();
