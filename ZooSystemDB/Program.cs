//Build a menu works based on integer input
using ZooSystemDB.Businness;
using ZooSystemDB.Consts;
using ZooSystemDB.Data;

int activeChoice = 0, menuChoice = 0, actionChoice = 0;
string[] SubMenuChoices = { "Back", "Animal", "Cage", "Worker" };
string[] SubMenuActions = { "Back", "Add", "Remove", "ListAllElements", "FindElementById" };
IWorkerService workerService = new WorkerService(new WorkerRepository());
ICageService cageService = new CageService(new CageRepository());
IAnimalService animalService = new AnimalService(new AnimalRepository());
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
        Console.WriteLine($"WELCOME TO {SubMenuChoices[menuChoice].ToUpper()} MENU!\nPLEASE CHOOSE AN ACTION:\n");
        Console.WriteLine(
    $"0 : {SubMenuActions[0]}\n" +
    $"1 : {SubMenuActions[1]} {SubMenuChoices[menuChoice]}\n" +
    $"2 : {SubMenuActions[2]} {SubMenuChoices[menuChoice]}\n" +
    $"3 : {SubMenuActions[3]}\n");

        switch (menuChoice)
        {
            case 0:
                Console.WriteLine("");
                break;
            case 1:
                Console.WriteLine("");
                break;
            case 2:
                Console.WriteLine("");
                break;
            case 3:
                Console.WriteLine("");
                break;
            case 4:
                Console.WriteLine("");
                break;
            default:
                Console.WriteLine("");
                break;
        }
        Console.WriteLine("Please Enter Your Choice:");
        string choiceString = Console.ReadLine();
        activeChoice = Convert.ToInt32(choiceString);
        actionChoice = activeChoice;
    }




    //CHOOSING AN ACTION IN SUBMENU
    else if (menuChoice > 0 && actionChoice > 0)
    {
        if(actionChoice is not 3)
        {
            Console.WriteLine($"Please Enter {SubMenuChoices[menuChoice]} Id:");
            string choiceString = Console.ReadLine();
            activeChoice = Convert.ToInt32(choiceString);
        }
        switch (menuChoice)
        {

            case 1:
                switch (actionChoice)
                {
                    case 3:
                        animalService.GetAll();
                        break;
                    case 2:
                        animalService.Delete(activeChoice);
                        break;
                    case 4:
                        animalService.GetById(activeChoice);
                        break;
                    case 1:
                        Animal tepAnimal = new Animal();
                        tepAnimal.Id_Animal = activeChoice;
                        Console.WriteLine("Please Enter Cage Id:");
                        string choiceString = Console.ReadLine();
                        tepAnimal.Id_Cage = Convert.ToInt32(choiceString);
                        Console.WriteLine("Please Enter Animal Name:");
                        tepAnimal.Name = Console.ReadLine();
                        tepAnimal.Specie = AnimalType.Penguin;
                        tepAnimal.LastAttended = DateTime.Now;
                        animalService.Add(tepAnimal);
                        break;
                    default:

                        break;
                }
                break;

            case 2:
                switch (actionChoice)
                {
                    case 3:
                        cageService.GetAll();
                        break;
                    case 2:
                        cageService.Delete(activeChoice);
                        break;
                    case 4:
                        cageService.GetById(activeChoice);
                        break;
                    case 1:
                        Cage tempCage = new Cage();
                        tempCage.Id_Cage = activeChoice;
                        Console.WriteLine("Please Enter Worker Ids seperated with a space:");
                        string choiceString = Console.ReadLine();
                        //Use Split to split integer id's into one place
                        var idsString = choiceString.Split(' ');
                        foreach (var id in idsString)
                            tempCage.WorkerList.Add(Convert.ToInt32(id));
                        Console.WriteLine("Please Enter Cage Name:");
                        tempCage.CageName = Console.ReadLine();
                        tempCage.CageType = AnimalType.Penguin;
                        cageService.Add(tempCage);
                        break;
                    default:

                        break;
                }
                break;

            case 3:
                switch (actionChoice)
                {
                    case 3:
                        workerService.GetAll();
                        break;
                    case 2:
                        workerService.Delete(activeChoice);
                        break;
                    case 4:
                        workerService.GetById(activeChoice);
                        break;
                    case 1:
                        Worker tempWorker = new Worker();
                        tempWorker.Id_Worker = activeChoice;
                        Console.WriteLine("Please Enter Cage Ids worker attends, seperated with a space:");
                        string choiceString = Console.ReadLine();
                        //Use Split to split integer id's into one place
                        var idsString = choiceString.Split(' ');
                        foreach (var id in idsString)
                            tempWorker.Id_AttendedCages.Add(Convert.ToInt32(id));
                        Console.WriteLine("Please Enter Worker Name:");
                        tempWorker.Name = Console.ReadLine();
                        tempWorker.WorkDays = new WorkDays[] { WorkDays.Monday, WorkDays.Tuesday, WorkDays.Wednesday, WorkDays.Thursday, WorkDays.Friday };
                        workerService.Add(tempWorker);
                        break;
                    default:

                        break;
                }
                break;
            default:
                //GO BACK
                break;
            
        }

    }



    //NO INPUT IS GIVEN EVER!!!
    else
    {

    }



} while (activeChoice < -1);
