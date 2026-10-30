


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

    public int GetBonusPoints()
    {
        return _pointsBonus;
    }

//logic for point awarding

    public int PointsEarned()
    {
        //i have completed this goal so the count goes up
        int countNew = _amtComplete;
        
        //i call the normal amt of points
        int pointsEarned = GetPoints();

        //if the counter matches iterations then I have fulfilled the target goal
        if (countNew == _iterations)
        {
            return pointsEarned + _pointsBonus;
        }
        else
        {
            return pointsEarned;
        }

    }


    // summary for human eyes
    public override string GetGoalSummary()
    {
        return $"{GetStatus()} - {GetName()} - {GetPoints()}";
    }



    // savestring for computer 

    // (name, description, points, bool, amtcompltere, iterations, bonus points) *might not need bool*

    public override string GetSaveString()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{IsComplete()}|{_amtComplete}|{_iterations}|{_pointsBonus}";
    }

}