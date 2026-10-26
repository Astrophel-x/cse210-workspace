# Classes

## Goal (abstract)

    private string _name
    private string _description
    private double _points [would be overridden?]

### Methods

    Goal(string name, string description, double points)
    {
        _name = name
        _description = description
        _points = points
    }
    Complete (abstract)
    {
        This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).
    }
    GetName
    {
        return _name
    }
    GetDescription
    {
        return _description
    }
    GetPoints
    {
        return _points
    }
    Status (abstract)
    {
        This method should return true if the goal is completed. The way you determine if a goal is complete is different for each type of goal.
    }

### SimpleGoal

    SimpleGoal : Goal

    bool _isCompleted

#### Methods

    SimpleGoal() : base(. . . )
    {
        _isCompleted = false;
    }

    SimpleGoal(bool isComplete) : base(. . . )
    {
        _isCompleted = isComplete
    }

    public override int Complete()
    {
        _isCompleted = true
        return points
    }

when completed:

- should update [STATUS]
- should add points to [POINT_TOTAL]
- should add task to [GOAL_LIST] as [DONE]

### EternalGoal

    public class EternalGoal : Goal

    private int _numCompleted

#### Methods

    EternalGoal() : base(. . . )
    {

    }
    public override int Complete()
    {
        return *something*
    }

when iteration completed:

- should add points to [POINT_TOTAL]
- should show amount of [times_completed]?

### ChecklistGoal

    int _repeatability
    int _numCompleted
    bool isComplete

    ChecklistGoal : Goal

#### Methods

    ChecklistGoal(int repeatability)
    {
    _repeatability = repeatability
    _isComplete = false
    }
    ChecklistGoal(int repeatability, int numCompleted)
    {
    _repeatability = repeatability
    _numCompleted = numCompleted
    if numCompleted >= repeatability
        _isComplete = true
    else
        _isComplete = false
    }

    public override -int- Complete()
    {
        _numComplete ++

        if _numCompleted >= _repeatabilty
            _points += 10
            _isComplete = true

        return points
    }

when iteration completed:

- should add points to [POINT_TOTAL]
- should update [STATUS] [X/X] in [TASK_LIST]

when entire goal is completed:

- should add [BONUS_POINTS] to [POINT_TOTAL]
- should update [STATUS] in [TASK_LIST]

## User

    private List<Goal> _goalsCompleted
    private List<Goal> _currentGoals
    private double _totalPoints

    AddGoal(Goal goal)
    {
        adds a goal to the _currentGoals
    }
    CompleteGoal(Goal goal)
    {
        removes a goal from _currentGoals and adds it to _goalsCompleted
    }
    SaveToFile(string filename)
    {
        saves contents to a file
    }
    LoadGoal(string filename)
    {
        loads contents from a file
    }

PriorCompleted

    **Allow the user to record an event (meaning they have accomplished a goal and should receive points).**

Write an Eternal Quest program to track various kinds of goals.

Your program can include whatever kinds of "gamification" components you like, but each program should have the following base functionality.

Functional requirements
Your program must do the following:

Provide for simple goals that can be marked complete and the user gains some value.
For example, if you run a marathon you get 1000 points.
Provide for eternal goals that are never complete, but each time the user records them, they gain some value.
For example, every time you read your scriptures you get 100 points.
Provide for a checklist goal that must be accomplished a certain number of times to be complete. Each time the user records this goal they gain some value, but when they achieve the desired amount, they get an extra bonus.
For example, if you set a goal to attend the temple 10 times, you might get 50 points each time you go, and then a bonus of 500 points on the 10th time.
Display the user's score.
Allow the user to create new goals of any type.
Allow the user to record an event (meaning they have accomplished a goal and should receive points).
Show a list of the goals. This list should show indicate whether the goal has been completed or not (for example [ ] compared to [X]), and for checklist goals it should show how many times the goal has been completed (for example Completed 2/5 times).
Allow the user's goals and their current score to be saved and loaded.
Design Requirements
In addition your program must:

Use inheritance by having a separate class for each kind of activity with a base class to contain any shared attributes or behaviors.
Use polymorphism by having derived classes override base class methods where appropriate.
Follow the principles of encapsulation and abstraction by having private member variables and putting related items in the same class.
