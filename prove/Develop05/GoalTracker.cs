


// and also menu but didn't want to make file name longer

using System.Drawing;

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
        while (userInput != "10")
        {
            Console.WriteLine("Welcome to Eternal Quest.");
            Console.WriteLine("Please choose from the following options: ");
            Console.WriteLine("1. Create New Simple Goal.");
            Console.WriteLine("2. Create New Checklist Goal.");
            Console.WriteLine("3. Create New Eternal Goal.");
            Console.WriteLine("4. Mark Active Goal As Complete. ");
            Console.WriteLine("5. Record Completed Goal.");
            Console.WriteLine("6. Show List of All Goals");
            Console.WriteLine("7. View Total Score.");
            Console.WriteLine("8. Save Current Goals and Score");
            Console.WriteLine("9. Load Other Goal and Score Profile");
            Console.WriteLine("10. Quit.");


            if (userInput == "1")
            {
                CreateSimpleGoal();                
            }
            else if (userInput == "2")
            {
                
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

// mark active goal as complete

    public void MarkGoalAsComplete(Goal goal)
    {
        //bool wasComplete = goal.IsComplete();

        if (goal is ChecklistGoal c)
        {
            int pointsEarned = c.PointsEarned();

            _pointsOverall += pointsEarned;

        }
        else
        {
            goal.RecordEvent();
            _pointsOverall += goal.GetPoints();
        }


    }



    // record completed event

    public void RecordPriorGoal()
    {
        GetUserCompletedGoalInfo(out string name, out string description, out int points);

        SimpleGoal newSimple = new SimpleGoal(name, description, points);

        _pointsOverall += points;

        _goals.Add(newSimple);



    }

// show list of all goals

    public void DisplayGoalsAll()
    {   
        Console.WriteLine("Would you like to see all active goals or a complete list? \n1. Active Goals\n2. All Goals");
        Console.Write("\n> ");
        string userInputGoalList = Console.ReadLine();

        if (userInputGoalList == "1")
        {
            DisplayGoalsActive();
        }


        if (userInputGoalList == "2")
        {    
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals! Let's get started!");
            }
            else
            {
                Console.WriteLine("");
                for (int i = 0; i < _goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {_goals[i].GetGoalSummary()}");
                }
            }
        }
    }

    // separate method for displaying active goals

    public void DisplayGoalsActive()
    {
        bool active = false;

        int j = 1;

        foreach (Goal goal in _goals)
        {
            if (!goal.IsComplete())
            {
                Console.WriteLine($"{j}. goal.GetGoalSummary()");
                active = true;
                j ++;
            }
            
        }

        if (!active)
        {
            Console.WriteLine("No active goals! Let's make a new one!");
        }
    }


    // display total
    public void DisplayPointsOverall()
    {
        Console.WriteLine($"Your point total is: {_pointsOverall}.");
    }

    // save

    public void Save()
    {
        Console.Write("What would you like to name your profile? Be sure to include '.txt' at the end.");
        string profileName = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter(profileName))
        {
            sw.WriteLine(_pointsOverall);

            foreach (Goal goal in _goals)
            {
                sw.WriteLine(goal.GetSaveString());
            }
        }
        
    }

    // load

    public void Load()
    {
        Console.WriteLine("What is the filename of the profile you would like to load? ");
        Console.Write("> ");
        string userInputFilename = Console.ReadLine();

        if (!File.Exists(userInputFilename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = System.IO.File.ReadAllLines(userInputFilename);

        _goals.Clear();

//snag overall pts from top
        _pointsOverall = int.Parse(lines[0]);
        

        foreach (string line in lines)
        {
            
            if (line.StartsWith("SimpleGoal"))
            {
                string[] parts = line.Split(',');
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool IsComplete = bool.Parse(parts[4]);

                SimpleGoal goal = new SimpleGoal(name, description, points);
                if (IsComplete)
                {
                    goal.RecordEvent();
                }

                _goals.Add(goal);

            }

            else if (line.StartsWith("EternalGoal,"))
            {
                string[] parts = line.Split(',');
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int iterations = int.Parse(parts[4]);

                EternalGoal goal = new EternalGoal(name, description, points);

                for (int i = 0; i < iterations; i ++)
                {
                    goal.RecordEvent();
                }

                _goals.Add(goal);
            }

            else if (line.StartsWith("ChecklistGoals"))
            {
                string[] parts = line.Split(',');
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool IsComplete = bool.Parse(parts[4]);
                int amtComplete = int.Parse(parts[5]);
                int iterations = int.Parse(parts[6]);
                int pointsBonus = int.Parse(parts[7]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, iterations, pointsBonus);

                for (int i = 0; i < amtComplete; i ++)
                {
                    goal.RecordEvent();
                }
                if (IsComplete)
                {
                    //do nothing i am pretty sure
                }

                _goals.Add(goal);
            }

        }

        Console.WriteLine("Profile Loaded!");

    }








}