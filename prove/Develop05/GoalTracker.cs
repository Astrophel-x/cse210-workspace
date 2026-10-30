


// and also menu but didn't want to make file name longer

class GoalTracker
{
    
    private List<Goal> _goals;
    private int _pointsOverall;




    public GoalTracker()
    {
        _goals = new List<Goal>();
        _pointsOverall = 0;
    }

    public void RecordPointsOverall()
    {
        
    }

//START THE WHOLE THING!! SHOWS OPTIONS
// user needs to: 

/* 
- create goal, and choose which kind of goal
- or show all goals to create at once
- display score
- record copmleted event
- show list
- save goals and score
- load goals and score

*/
    public void DisplayMenu()
    {
        string userInput = "";
        while (userInput != "8")
        {
            Console.WriteLine("Welcome to Eternal Quest.");
            Console.WriteLine("Please choose from the following options: ");
            Console.WriteLine("1. Create New Simple Goal.");
            Console.WriteLine("2. Create New Checklist Goal.");
            Console.WriteLine("3. Create New Eternal Goal.");
            Console.WriteLine("4. Record Completed Goal.");
            Console.WriteLine("Show List of All Goals");
            Console.WriteLine("5. View Total Score.");
            Console.WriteLine("6. Save Current Goals and Score");
            Console.WriteLine("7. Load Other Goal and Score Profile");
            Console.WriteLine("8. Quit.");


            if (userInput == "1")
            {
                CreateSimpleGoal();                
            }



        }
    }


//gather goal info

    public void GetUserGoalInfo(out string name, out string description, out int points)
    {

        Console.WriteLine("What would you like to name your goal? ");
        Console.Write("> ");

        name = Console.ReadLine();

        Console.WriteLine("What is a short description of your goal? ");
        Console.Write("> ");
        description = Console.ReadLine();

        Console.WriteLine("How many points is this goal worth? ");
        Console.Write("> ");
        points = int.Parse(Console.ReadLine());

    }

    public void GetUserCompletedGoalInfo(out string name, out string description, out int points)
    {
        Console.WriteLine("What was the name of your goal? ");
        Console.Write("> ");

        name = Console.ReadLine();

        Console.WriteLine("What is a short description of your goal? ");
        Console.Write("> ");
        description = Console.ReadLine();

        Console.WriteLine("How many points is this goal worth? ");
        Console.Write("> ");
        points = int.Parse(Console.ReadLine());    
    }

// 1. Create Simple Goal
    public void CreateSimpleGoal()
    {
        GetUserGoalInfo(out string name, out string description, out int points);
        SimpleGoal newSimple = new SimpleGoal(name, description, points);
        _goals.Add(newSimple);
    }

// 2. Create Checklist Goal
    public void CreateChecklistGoal()
    {
        GetUserGoalInfo(out string name, out string description, out int points);
        Console.WriteLine("How many times would you like to iterate through this goal? ");
        Console.Write("> ");
        int iterations = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("How many bonus points would you like upon completion?");
        Console.Write("> ");
        int pointsBonus = int.Parse(Console.ReadLine());
        ChecklistGoal newChecklist = new ChecklistGoal(name, description, points, iterations, pointsBonus);
        _goals.Add(newChecklist);
    }



    // 3. create eternal goal
    public void CreateEternalGoal()
    {
        GetUserGoalInfo(out string name, out string description, out int points);
        EternalGoal newEternal = new EternalGoal(name, description, points);

        _goals.Add(newEternal);

    }

    // record completed event

}