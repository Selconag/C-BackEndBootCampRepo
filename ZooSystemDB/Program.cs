//Build a menu works based on integer input
using ZooSystemDB.Consts;

int activeChoice = 0, menuChoice = 0, actionChoice = 0;
string[] SubMenuChoices = { "Back", "Animal", "Cage", "Worker" };
string[] SubMenuActions = { "Back", "Add", "Remove", "ListAllElements", "FindElementById" };
do
{
    //ENTERING MAIN MENU
    if (menuChoice <= 0 && actionChoice <= 0)
    {
        Console.WriteLine("WELCOME TO ZOO DATABASE!\nPLEASE CHOOSE A MENU:\n");
        Console.WriteLine(
            "0 : Close\n" +
            "1 : Animals Menu\n" +
            "2 : Cages Menu\n" +
            "3 : Workers Menu\n");
        Console.WriteLine("Please Enter Your Choice:");
        string choiceString = Console.ReadLine();
        activeChoice = Convert.ToInt32(choiceString);
        menuChoice = activeChoice;
    }
    //ENTERING A SUBMENU
    else if (menuChoice > 0 && actionChoice <= 0)
    {
        //Console.WriteLine($"WELCOME TO {MainMenuChoice[menuChoice].ToString()}!\nPLEASE CHOOSE A MENU:\n");


        switch (menuChoice)
        {
            case 0:
                Console.WriteLine("WELCOME TO ZOO DATABASE!\nPLEASE CHOOSE A MENU:\n");
                break;
            case 1:
                Console.WriteLine("WELCOME TO ZOO DATABASE!\nPLEASE CHOOSE A MENU:\n");
                break;
            case 2:
                Console.WriteLine("WELCOME TO ZOO DATABASE!\nPLEASE CHOOSE A MENU:\n");
                break;
            case 3:
                Console.WriteLine("WELCOME TO ZOO DATABASE!\nPLEASE CHOOSE A MENU:\n");
                break;
            case 4:
                Console.WriteLine("WELCOME TO ZOO DATABASE!\nPLEASE CHOOSE A MENU:\n");
                break;
            default:
                Console.WriteLine("WELCOME TO ZOO DATABASE!\nPLEASE CHOOSE A MENU:\n");
                break;
        }
        Console.WriteLine(
    "0 : Close\n" +
    "1 : Animals Menu\n" +
    "2 : Cages Menu\n" +
    "3 : Workers Menu\n");
        Console.WriteLine("Please Enter Your Choice:");
        string choiceString = Console.ReadLine();
        activeChoice = Convert.ToInt32(choiceString);
        menuChoice = activeChoice;
    }
    //CHOOSING AN ACTION IN SUBMENU
    else if (menuChoice > 0 && actionChoice > 0)
    {
        switch (actionChoice)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            default:
                break;
        }
    }
    //NO INPUT IS GIVEN EVER!!!
    else
    {

    }
} while (activeChoice < -1);
