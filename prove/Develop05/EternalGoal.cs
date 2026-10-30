

class EternalGoal : Goal
{
    private int _iterations;
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _iterations = 0;
    }


//uh. if tracking how many times completed, would prolly be here. 
    public override void RecordEvent()
    {
        _iterations ++;
    }


    public override bool IsComplete()
    {
        return false;

    }

    public override string GetStatus()
    {
        if (_iterations == 1)
        {
            return $"Completed {_iterations} time.";
        }
        else
        {
            return $"Completed {_iterations} times.";
        }
    }


    //human eyes

    public override string GetGoalSummary()
    {
        return $"{GetName()} - {GetPoints()} - {GetPoints()} - {GetStatus()}";
    }


//computer save
    public override string GetSaveString()
    {
        return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()},{_iterations}";
    }
}