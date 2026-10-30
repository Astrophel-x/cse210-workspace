



class SimpleGoal : Goal
{
    //private string _Status;
    private bool _IsComplete;




    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _IsComplete = false;
        
    }


//Status of checked off or not
    public override string GetStatus()
    {
        if (_IsComplete == true)
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }

//Change the status of a goal, yes it is complete
    public override void RecordEvent()
    {
        _IsComplete = true;
    }


    // check if goal IsComplete yet
    public override bool IsComplete()
    {
        return _IsComplete;
    }


// default summary display method doesn't need editing for simplegoal

    //to save to file
    public override string GetSaveString()
    {
        return $"SimpleGoal:{GetName()},{GetDescription()},{GetPoints()},{_IsComplete}";
    }



}