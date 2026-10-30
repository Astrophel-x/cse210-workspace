
// base ## Goal (abstract)

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    //private bool _IsComplete = false;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }



    public abstract void RecordEvent();
    public abstract string GetStatus();
    public abstract bool IsComplete();

//for human eyes, details
    public virtual string GetGoalSummary()
    {
        if (IsComplete() == true)
        {
            return $"[X] {GetName()} : {GetDescription()}";
        }
        else
        {
            return $"[ ] {GetName()} : {GetDescription()}";
        }
    }

// for the computer/save file
    public abstract string GetSaveString();

}