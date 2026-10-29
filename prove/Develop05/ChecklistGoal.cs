


class ChecklistGoal : Goal
{
    private int _amtComplete;
    private int _iterations;
    private int _pointsBonus;

    public ChecklistGoal(string name, string description, int points, int iterations, int pointsBonus) : base(name, description, points)
    {
        _amtComplete = 0;
        _iterations = iterations;
        _pointsBonus = pointsBonus;
        
    }

//when an iteration is complete, record it
    public override void RecordEvent()
    {
        _amtComplete ++ ;
    }

    

    public override bool IsComplete()
    {
        if (_amtComplete == _iterations)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

//status [X] or  not
    public override string GetStatus()
    {
        if (_amtComplete >= _iterations)
        {
            return $"[X] : {_amtComplete}/{_iterations}";
        }
        else
        {
            return $"[ ] : {_amtComplete}/{_iterations}";
        }

    }


    // savestring

    public override string GetSaveString()
    {
        return $"ChecklistGoal:{GetName()},"
    }

}